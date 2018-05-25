//==============================================================================
//
//  This file was auto-generated by a tool using the PayPal REST API schema.
//  More information: https://developer.paypal.com/docs/api/
//
//==============================================================================
using Newtonsoft.Json;

namespace PayPal.Api
{
    /// <summary>
    /// Extended Address object used as shipping address in a payment.
    /// <para>
    /// See <a href="https://developer.paypal.com/docs/api/">PayPal Developer documentation</a> for more information.
    /// </para>
    /// </summary>
    public class ShippingAddress : Address
    {
        /// <summary>
        /// Address ID assigned in PayPal system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id")]
        public string id { get; set; }

        /// <summary>
        /// Name of the recipient at this address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient_name")]
        public string recipient_name { get; set; }

        /// <summary>
        /// Default shipping address of the Payer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "default_address")]
        public bool? default_address { get; set; }

        /// <summary>
        /// Shipping Address marked as preferred by Payer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferred_address")]
        public bool? preferred_address { get; set; }
    }
}
