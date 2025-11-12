using Backend;
using Backend.Protocol;
using FluentAssertions;
namespace BackendTest.Protocol;

[TestFixture]
[TestOf(typeof(Envelope))]
public class EnvelopeTest
{

    [Test]
    public void TestCreateImport()
    {
        //Arrange
        Envelope envelope = new Envelope(senderId : "senderId",message : "content",type : MessageType.HELLO);
        
        //Act
        var clone = Envelope.FromJson(envelope.ToJson());
        
        //Assert
        clone.Should().BeEquivalentTo(envelope);
        

    }
    
    [Test]
    public void TestDeserialize()
    {
        Assert.That(
            Envelope.FromJson("{\"Id\":\"272728e8-a413-4ba9-b4fc-dffb49ab5818\",\"SenderId\":\"localhost\",\"Type\":0,\"Message\":\"bob4\"}"),Is.Not.Null);
    }
}