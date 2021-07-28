/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Conversations.V1;

namespace Twilio.Tests.Rest.Conversations.V1
{

    [TestFixture]
    public class ParticipantConversationTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Conversations,
                "/v1/ParticipantConversations",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantConversationResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"conversations\": [],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://conversations.twilio.com/v1/ParticipantConversations?Identity=identity&PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://conversations.twilio.com/v1/ParticipantConversations?Identity=identity&PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"conversations\"}}"
                                     ));

            var response = ParticipantConversationResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullByIdentityResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"conversations\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"chat_service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"participant_sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_friendly_name\": \"friendly_name\",\"conversation_state\": \"inactive\",\"conversation_timers\": {\"date_inactive\": \"2015-12-16T22:19:38Z\",\"date_closed\": \"2015-12-16T22:28:38Z\"},\"conversation_attributes\": \"{}\",\"conversation_date_created\": \"2015-07-30T20:00:00Z\",\"conversation_date_updated\": \"2015-07-30T20:00:00Z\",\"conversation_created_by\": \"created_by\",\"conversation_unique_name\": \"unique_name\",\"participant_user_sid\": \"USaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"participant_identity\": \"identity\",\"participant_messaging_binding\": null,\"links\": {\"participant\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://conversations.twilio.com/v1/ParticipantConversations?Identity=identity&PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://conversations.twilio.com/v1/ParticipantConversations?Identity=identity&PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"conversations\"}}"
                                     ));

            var response = ParticipantConversationResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullByAddressResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"conversations\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"chat_service_sid\": \"ISaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"participant_sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_friendly_name\": \"friendly_name\",\"conversation_state\": \"inactive\",\"conversation_timers\": {\"date_inactive\": \"2015-12-16T22:19:38Z\",\"date_closed\": \"2015-12-16T22:28:38Z\"},\"conversation_attributes\": \"{}\",\"conversation_date_created\": \"2015-07-30T20:00:00Z\",\"conversation_date_updated\": \"2015-07-30T20:00:00Z\",\"conversation_created_by\": \"created_by\",\"conversation_unique_name\": \"unique_name\",\"participant_user_sid\": null,\"participant_identity\": null,\"participant_messaging_binding\": {\"address\": \"+375255555555\",\"proxy_address\": \"+12345678910\",\"type\": \"sms\",\"level\": null,\"name\": null,\"projected_address\": null},\"links\": {\"participant\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://conversations.twilio.com/v1/ParticipantConversations?Address=%2B375255555555&PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://conversations.twilio.com/v1/ParticipantConversations?Address=%2B375255555555&PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"conversations\"}}"
                                     ));

            var response = ParticipantConversationResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}