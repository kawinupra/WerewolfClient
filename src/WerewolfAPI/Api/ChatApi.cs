/* 
 * Werewolf Engine
 *
 * This is a werewolf game engine for REST access. It is primarily developed for CPE200 class at Computer Engineering, Chiang Mai University.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: pruetboonma@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using WerewolfAPI.Client;
using WerewolfAPI.Model;

namespace WerewolfAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChatApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve list of chat messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="chatID">First chat message ID to retrieve</param>
        /// <returns>List&lt;ChatMessage&gt;</returns>
        List<ChatMessage> ChatGameIDSessionIDChatIDGet (int? gameID, string sessionID, int? chatID);

        /// <summary>
        /// Retrieve list of chat messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="chatID">First chat message ID to retrieve</param>
        /// <returns>ApiResponse of List&lt;ChatMessage&gt;</returns>
        ApiResponse<List<ChatMessage>> ChatGameIDSessionIDChatIDGetWithHttpInfo (int? gameID, string sessionID, int? chatID);
        /// <summary>
        /// Post a message to game
        /// </summary>
        /// <remarks>
        /// Post a message to game
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="body">Chat message object to post to the game</param>
        /// <returns></returns>
        void ChatGameIDSessionIDPost (long? gameID, string sessionID, ChatMessage body);

        /// <summary>
        /// Post a message to game
        /// </summary>
        /// <remarks>
        /// Post a message to game
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="body">Chat message object to post to the game</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ChatGameIDSessionIDPostWithHttpInfo (long? gameID, string sessionID, ChatMessage body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve list of chat messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="chatID">First chat message ID to retrieve</param>
        /// <returns>Task of List&lt;ChatMessage&gt;</returns>
        System.Threading.Tasks.Task<List<ChatMessage>> ChatGameIDSessionIDChatIDGetAsync (int? gameID, string sessionID, int? chatID);

        /// <summary>
        /// Retrieve list of chat messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="chatID">First chat message ID to retrieve</param>
        /// <returns>Task of ApiResponse (List&lt;ChatMessage&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ChatMessage>>> ChatGameIDSessionIDChatIDGetAsyncWithHttpInfo (int? gameID, string sessionID, int? chatID);
        /// <summary>
        /// Post a message to game
        /// </summary>
        /// <remarks>
        /// Post a message to game
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="body">Chat message object to post to the game</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ChatGameIDSessionIDPostAsync (long? gameID, string sessionID, ChatMessage body);

        /// <summary>
        /// Post a message to game
        /// </summary>
        /// <remarks>
        /// Post a message to game
        /// </remarks>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="body">Chat message object to post to the game</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ChatGameIDSessionIDPostAsyncWithHttpInfo (long? gameID, string sessionID, ChatMessage body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ChatApi : IChatApi
    {
        private WerewolfAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChatApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = WerewolfAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ChatApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = WerewolfAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public WerewolfAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieve list of chat messages 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="chatID">First chat message ID to retrieve</param>
        /// <returns>List&lt;ChatMessage&gt;</returns>
        public List<ChatMessage> ChatGameIDSessionIDChatIDGet (int? gameID, string sessionID, int? chatID)
        {
             ApiResponse<List<ChatMessage>> localVarResponse = ChatGameIDSessionIDChatIDGetWithHttpInfo(gameID, sessionID, chatID);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve list of chat messages 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="chatID">First chat message ID to retrieve</param>
        /// <returns>ApiResponse of List&lt;ChatMessage&gt;</returns>
        public ApiResponse< List<ChatMessage> > ChatGameIDSessionIDChatIDGetWithHttpInfo (int? gameID, string sessionID, int? chatID)
        {
            // verify the required parameter 'gameID' is set
            if (gameID == null)
                throw new ApiException(400, "Missing required parameter 'gameID' when calling ChatApi->ChatGameIDSessionIDChatIDGet");
            // verify the required parameter 'sessionID' is set
            if (sessionID == null)
                throw new ApiException(400, "Missing required parameter 'sessionID' when calling ChatApi->ChatGameIDSessionIDChatIDGet");
            // verify the required parameter 'chatID' is set
            if (chatID == null)
                throw new ApiException(400, "Missing required parameter 'chatID' when calling ChatApi->ChatGameIDSessionIDChatIDGet");

            var localVarPath = "/chat/{gameID}/{sessionID}/{chatID}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (gameID != null) localVarPathParams.Add("gameID", Configuration.ApiClient.ParameterToString(gameID)); // path parameter
            if (sessionID != null) localVarPathParams.Add("sessionID", Configuration.ApiClient.ParameterToString(sessionID)); // path parameter
            if (chatID != null) localVarPathParams.Add("chatID", Configuration.ApiClient.ParameterToString(chatID)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChatGameIDSessionIDChatIDGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ChatMessage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ChatMessage>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ChatMessage>)));
        }

        /// <summary>
        /// Retrieve list of chat messages 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="chatID">First chat message ID to retrieve</param>
        /// <returns>Task of List&lt;ChatMessage&gt;</returns>
        public async System.Threading.Tasks.Task<List<ChatMessage>> ChatGameIDSessionIDChatIDGetAsync (int? gameID, string sessionID, int? chatID)
        {
             ApiResponse<List<ChatMessage>> localVarResponse = await ChatGameIDSessionIDChatIDGetAsyncWithHttpInfo(gameID, sessionID, chatID);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve list of chat messages 
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="chatID">First chat message ID to retrieve</param>
        /// <returns>Task of ApiResponse (List&lt;ChatMessage&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ChatMessage>>> ChatGameIDSessionIDChatIDGetAsyncWithHttpInfo (int? gameID, string sessionID, int? chatID)
        {
            // verify the required parameter 'gameID' is set
            if (gameID == null)
                throw new ApiException(400, "Missing required parameter 'gameID' when calling ChatApi->ChatGameIDSessionIDChatIDGet");
            // verify the required parameter 'sessionID' is set
            if (sessionID == null)
                throw new ApiException(400, "Missing required parameter 'sessionID' when calling ChatApi->ChatGameIDSessionIDChatIDGet");
            // verify the required parameter 'chatID' is set
            if (chatID == null)
                throw new ApiException(400, "Missing required parameter 'chatID' when calling ChatApi->ChatGameIDSessionIDChatIDGet");

            var localVarPath = "/chat/{gameID}/{sessionID}/{chatID}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (gameID != null) localVarPathParams.Add("gameID", Configuration.ApiClient.ParameterToString(gameID)); // path parameter
            if (sessionID != null) localVarPathParams.Add("sessionID", Configuration.ApiClient.ParameterToString(sessionID)); // path parameter
            if (chatID != null) localVarPathParams.Add("chatID", Configuration.ApiClient.ParameterToString(chatID)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChatGameIDSessionIDChatIDGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ChatMessage>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ChatMessage>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ChatMessage>)));
        }

        /// <summary>
        /// Post a message to game Post a message to game
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="body">Chat message object to post to the game</param>
        /// <returns></returns>
        public void ChatGameIDSessionIDPost (long? gameID, string sessionID, ChatMessage body)
        {
             ChatGameIDSessionIDPostWithHttpInfo(gameID, sessionID, body);
        }

        /// <summary>
        /// Post a message to game Post a message to game
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="body">Chat message object to post to the game</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ChatGameIDSessionIDPostWithHttpInfo (long? gameID, string sessionID, ChatMessage body)
        {
            // verify the required parameter 'gameID' is set
            if (gameID == null)
                throw new ApiException(400, "Missing required parameter 'gameID' when calling ChatApi->ChatGameIDSessionIDPost");
            // verify the required parameter 'sessionID' is set
            if (sessionID == null)
                throw new ApiException(400, "Missing required parameter 'sessionID' when calling ChatApi->ChatGameIDSessionIDPost");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->ChatGameIDSessionIDPost");

            var localVarPath = "/chat/{gameID}/{sessionID}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (gameID != null) localVarPathParams.Add("gameID", Configuration.ApiClient.ParameterToString(gameID)); // path parameter
            if (sessionID != null) localVarPathParams.Add("sessionID", Configuration.ApiClient.ParameterToString(sessionID)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChatGameIDSessionIDPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Post a message to game Post a message to game
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="body">Chat message object to post to the game</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ChatGameIDSessionIDPostAsync (long? gameID, string sessionID, ChatMessage body)
        {
             await ChatGameIDSessionIDPostAsyncWithHttpInfo(gameID, sessionID, body);

        }

        /// <summary>
        /// Post a message to game Post a message to game
        /// </summary>
        /// <exception cref="WerewolfAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="gameID">ID of game to perform action</param>
        /// <param name="sessionID">ID of player&#39;session to perform chat</param>
        /// <param name="body">Chat message object to post to the game</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ChatGameIDSessionIDPostAsyncWithHttpInfo (long? gameID, string sessionID, ChatMessage body)
        {
            // verify the required parameter 'gameID' is set
            if (gameID == null)
                throw new ApiException(400, "Missing required parameter 'gameID' when calling ChatApi->ChatGameIDSessionIDPost");
            // verify the required parameter 'sessionID' is set
            if (sessionID == null)
                throw new ApiException(400, "Missing required parameter 'sessionID' when calling ChatApi->ChatGameIDSessionIDPost");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ChatApi->ChatGameIDSessionIDPost");

            var localVarPath = "/chat/{gameID}/{sessionID}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (gameID != null) localVarPathParams.Add("gameID", Configuration.ApiClient.ParameterToString(gameID)); // path parameter
            if (sessionID != null) localVarPathParams.Add("sessionID", Configuration.ApiClient.ParameterToString(sessionID)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ChatGameIDSessionIDPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
