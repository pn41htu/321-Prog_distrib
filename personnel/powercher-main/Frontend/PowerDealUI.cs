using Backend;
using Backend.Protocol;
using DataModel;
using Frontend.Logging;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Frontend
{
    public partial class PowerDealUI : Form
    {
        private ILogger _logger;
        private Agent _agent;
        private Envelope? _priceBroadcast = null;
        private PowerTransaction _priceOffer;


        public PowerDealUI(string broker)
        {
            InitializeComponent();
            var loggerFactory = LoggerFactory.Create(
                builder => builder
                    .AddConsole()
                    .SetMinimumLevel(LogLevel.Debug)
            );
            _logger = loggerFactory.CreateLogger<PowerWatchUI>();
            _agent = new Agent(loggerFactory, broker, OnMessageReceived, idPrefix: "PD-");
            _agent.Start();
            nudKwhPrice_ValueChanged(new Object(), new EventArgs());
        }

        private void OnMessageReceived(Envelope envelope)
        {
            if (envelope.SenderId == _agent.NodeId) return; // Ignore my own messages

            switch (envelope.Type)
            {
                case MessageType.CASH:
                    break;
                case MessageType.POWER:
                    PowerTransaction powtr = JsonSerializer.Deserialize<PowerTransaction>(envelope.Message);
                    switch (powtr.Type)
                    {
                        case PowerTransactionType.ENERGY_OFFER_RESPONSE:
                            // we currently don't purchase energy from houses
                            break;
                        case PowerTransactionType.ENERGY_NEED_REQUEST:
                            // Accept all deals for now, but on my terms
                            PowerTransaction response = new PowerTransaction(PowerTransactionType.ENERGY_OFFER_RESPONSE, powtr.Amount * (double)nudKwhPrice.Value, powtr.Amount);
                            _agent.Send(new Envelope(_agent.NodeId, MessageType.POWER, response.ToJson(), envelope.SenderId));
                            break;
                    }
                    break;
            }
        }

        private void tmrSpendCash_Tick(object sender, EventArgs e)
        {
            _agent.Send(_priceBroadcast);
        }

        private void nudKwhPrice_ValueChanged(object sender, EventArgs e)
        {
            // regenerate the price offer envelope with new Id
            _priceOffer = new PowerTransaction(PowerTransactionType.ENERGY_OFFER_REQUEST, (double)nudKwhPrice.Value, 1.0);
            _priceBroadcast = new Envelope(_agent.NodeId, MessageType.POWER, _priceOffer.ToJson());
        }
    }
}
