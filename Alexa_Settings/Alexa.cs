using System;
using System.Reflection;

namespace Alexa_Settings
{
    public class Alexa
    {
        private readonly AlexaParams _alexaParams = null;

        public Alexa()
        {
            _alexaParams = new AlexaParams() { GreetingMessage = "hello, i am Alexa" };
        }
        
        public string Talk()
        {
            var message = _alexaParams.GreetingMessage;
            foreach (PropertyInfo property in typeof(AlexaParams).GetProperties())
            {
                var value = property.GetValue(_alexaParams, null);
                message = message.Replace("{ " + property.Name + " }", value?.ToString());
            }
            return message;
        }

        public void Configure(Action<AlexaParams> alexa)
        {
            alexa(_alexaParams);
        }
    }

    public class AlexaParams
    {
        public string GreetingMessage { get; set; }

        public string OwnerName { get; set; }
    }
}
