/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// BundleCopyResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Numbers.V2.RegulatoryCompliance.Bundle
{

    public class BundleCopyResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Draft = new StatusEnum("draft");
            public static readonly StatusEnum PendingReview = new StatusEnum("pending-review");
            public static readonly StatusEnum InReview = new StatusEnum("in-review");
            public static readonly StatusEnum TwilioRejected = new StatusEnum("twilio-rejected");
            public static readonly StatusEnum TwilioApproved = new StatusEnum("twilio-approved");
            public static readonly StatusEnum ProvisionallyApproved = new StatusEnum("provisionally-approved");
        }

        public sealed class EndUserTypeEnum : StringEnum
        {
            private EndUserTypeEnum(string value) : base(value) {}
            public EndUserTypeEnum() {}
            public static implicit operator EndUserTypeEnum(string value)
            {
                return new EndUserTypeEnum(value);
            }

            public static readonly EndUserTypeEnum Individual = new EndUserTypeEnum("individual");
            public static readonly EndUserTypeEnum Business = new EndUserTypeEnum("business");
        }

        private static Request BuildCreateRequest(CreateBundleCopyOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Numbers,
                "/v2/RegulatoryCompliance/Bundles/" + options.PathBundleSid + "/Copies",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Creates a new copy of a Bundle. It will internally create copies of all the bundle items (identities and documents)
        /// of the original bundle
        /// </summary>
        /// <param name="options"> Create BundleCopy parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BundleCopy </returns>
        public static BundleCopyResource Create(CreateBundleCopyOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Creates a new copy of a Bundle. It will internally create copies of all the bundle items (identities and documents)
        /// of the original bundle
        /// </summary>
        /// <param name="options"> Create BundleCopy parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BundleCopy </returns>
        public static async System.Threading.Tasks.Task<BundleCopyResource> CreateAsync(CreateBundleCopyOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Creates a new copy of a Bundle. It will internally create copies of all the bundle items (identities and documents)
        /// of the original bundle
        /// </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle to be copied </param>
        /// <param name="friendlyName"> The string that you assigned to describe the copied bundle </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BundleCopy </returns>
        public static BundleCopyResource Create(string pathBundleSid,
                                                string friendlyName = null,
                                                ITwilioRestClient client = null)
        {
            var options = new CreateBundleCopyOptions(pathBundleSid){FriendlyName = friendlyName};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Creates a new copy of a Bundle. It will internally create copies of all the bundle items (identities and documents)
        /// of the original bundle
        /// </summary>
        /// <param name="pathBundleSid"> The unique string that identifies the Bundle to be copied </param>
        /// <param name="friendlyName"> The string that you assigned to describe the copied bundle </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BundleCopy </returns>
        public static async System.Threading.Tasks.Task<BundleCopyResource> CreateAsync(string pathBundleSid,
                                                                                        string friendlyName = null,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new CreateBundleCopyOptions(pathBundleSid){FriendlyName = friendlyName};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a BundleCopyResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BundleCopyResource object represented by the provided JSON </returns>
        public static BundleCopyResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<BundleCopyResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The unique string of a regulation
        /// </summary>
        [JsonProperty("regulation_sid")]
        public string RegulationSid { get; private set; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The verification status of the Bundle resource
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BundleCopyResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource will be valid until
        /// </summary>
        [JsonProperty("valid_until")]
        public DateTime? ValidUntil { get; private set; }
        /// <summary>
        /// The email address
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; private set; }
        /// <summary>
        /// The URL we call to inform your application of status changes
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        private BundleCopyResource()
        {

        }
    }

}