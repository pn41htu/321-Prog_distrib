using Backend.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerCrypt;
using DataModel;
using System.Text.Json;
using FluentAssertions;

namespace BackendTest;

[TestFixture]
[TestOf(typeof(EncryptionHelper))]

public class TestEncryptionHelper
{
    [Test]
    public void TestInitialization()
    {
        string keyfile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Powercher\power.key";

        
        // save existing key file if any
        if (File.Exists(keyfile))
        {
            var backup = keyfile + ".bck";
            if(File.Exists(backup)) File.Delete(backup);
            File.Move(keyfile, backup);
        }
        else if (!Directory.Exists(Path.GetDirectoryName(keyfile)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(keyfile)!);
        }
        try
        {
            // generate a new valid key
            PowerKey key = new PowerKey(DateTime.Now.AddDays(10));
            File.WriteAllText(keyfile, JsonSerializer.Serialize(key));
            Assert.That(EncryptionHelper.Initialize(), Is.True);

            // generate a new expired key
            key = new PowerKey(DateTime.Now.AddDays(-10));
            File.WriteAllText(keyfile, JsonSerializer.Serialize(key));
            Assert.That(EncryptionHelper.Initialize(), Is.False);

            // destroy key file
            File.Delete(keyfile);
            Assert.That(EncryptionHelper.Initialize(), Is.False);
        }
        finally
        {
            // restore save file
            File.Delete(keyfile);
            if (File.Exists(keyfile + ".bck")) File.Move(keyfile + ".bck", keyfile);
        }
    }

    [Test]
    public void TestEncryptDecrypt()
    {
        Assert.That(EncryptionHelper.Initialize(),Is.True);

        Assert.That(EncryptionHelper.DecryptString(EncryptionHelper.EncryptString("tcho")), Is.EqualTo("tcho"));
    }
}
