namespace Azure.Communication.CallingServer
{
    public partial class AddParticipantsFailed : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal AddParticipantsFailed() { }
        public string OperationContext { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Communication.CommunicationIdentifier> Participants { get { throw null; } }
        public Azure.Communication.CallingServer.ResultInformation ResultInfo { get { throw null; } }
        public static Azure.Communication.CallingServer.AddParticipantsFailed Deserialize(string content) { throw null; }
    }
    public partial class AddParticipantsResult
    {
        internal AddParticipantsResult() { }
        public string OperationContext { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Communication.CallingServer.CallParticipant> Participants { get { throw null; } }
    }
    public partial class AddParticipantsSucceeded : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal AddParticipantsSucceeded() { }
        public string OperationContext { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Communication.CommunicationIdentifier> Participants { get { throw null; } }
        public Azure.Communication.CallingServer.ResultInformation ResultInfo { get { throw null; } }
        public static Azure.Communication.CallingServer.AddParticipantsSucceeded Deserialize(string content) { throw null; }
    }
    public partial class AnswerCallOptions
    {
        public AnswerCallOptions(string incomingCallContext) { }
        public System.Uri CallbackEndpoint { get { throw null; } set { } }
        public string IncomingCallContext { get { throw null; } }
        public Azure.Communication.CallingServer.MediaStreamingConfiguration MediaStreamingConfiguration { get { throw null; } set { } }
    }
    public partial class AnswerCallResult
    {
        internal AnswerCallResult() { }
        public Azure.Communication.CallingServer.CallConnection CallConnection { get { throw null; } }
        public Azure.Communication.CallingServer.CallConnectionProperties CallConnectionProperties { get { throw null; } }
    }
    public partial class CallAutomationClient
    {
        protected CallAutomationClient() { }
        public CallAutomationClient(string connectionString) { }
        public CallAutomationClient(string connectionString, Azure.Communication.CallingServer.CallAutomationClientOptions options) { }
        public CallAutomationClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Communication.CallingServer.CallAutomationClientOptions options = null) { }
        public CallAutomationClient(System.Uri pmaEndpoint, string connectionString, Azure.Communication.CallingServer.CallAutomationClientOptions options = null) { }
        public virtual Azure.Response<Azure.Communication.CallingServer.AnswerCallResult> AnswerCall(Azure.Communication.CallingServer.AnswerCallOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.CallingServer.AnswerCallResult> AnswerCall(string incomingCallContext, System.Uri callbackEndpoint, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.AnswerCallResult>> AnswerCallAsync(Azure.Communication.CallingServer.AnswerCallOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.AnswerCallResult>> AnswerCallAsync(string incomingCallContext, System.Uri callbackEndpoint, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.CallingServer.CreateCallResult> CreateCall(Azure.Communication.CallingServer.CallSource source, System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> targets, System.Uri callbackEndpoint, string subject = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.CallingServer.CreateCallResult> CreateCall(Azure.Communication.CallingServer.CreateCallOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.CreateCallResult>> CreateCallAsync(Azure.Communication.CallingServer.CallSource source, System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> targets, System.Uri callbackEndpoint, string subject = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.CreateCallResult>> CreateCallAsync(Azure.Communication.CallingServer.CreateCallOptions options = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Communication.CallingServer.CallConnection GetCallConnection(string callConnectionId) { throw null; }
        public virtual Azure.Communication.CallingServer.CallRecording GetCallRecording() { throw null; }
        public virtual Azure.Response RedirectCall(string incomingCallContext, Azure.Communication.CommunicationIdentifier target, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RedirectCallAsync(string incomingCallContext, Azure.Communication.CommunicationIdentifier target, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response RejectCall(string incomingCallContext, Azure.Communication.CallingServer.CallRejectReason callRejectReason, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RejectCallAsync(string incomingCallContext, Azure.Communication.CallingServer.CallRejectReason callRejectReason, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CallAutomationClientOptions : Azure.Core.ClientOptions
    {
        public CallAutomationClientOptions(Azure.Communication.CallingServer.CallAutomationClientOptions.ServiceVersion version = Azure.Communication.CallingServer.CallAutomationClientOptions.ServiceVersion.V2022_04_07_Preview) { }
        public enum ServiceVersion
        {
            V2022_04_07_Preview = 1,
        }
    }
    public abstract partial class CallAutomationEventBase
    {
        protected CallAutomationEventBase() { }
        public string CallConnectionId { get { throw null; } }
        public string CorrelationId { get { throw null; } }
        public string ServerCallId { get { throw null; } }
    }
    public static partial class CallAutomationEventParser
    {
        public static Azure.Communication.CallingServer.CallAutomationEventBase Parse(Azure.Messaging.CloudEvent cloudEvent) { throw null; }
        public static Azure.Communication.CallingServer.CallAutomationEventBase Parse(System.BinaryData json) { throw null; }
        public static Azure.Communication.CallingServer.CallAutomationEventBase Parse(string eventData, string eventType) { throw null; }
        public static Azure.Communication.CallingServer.CallAutomationEventBase[] ParseMany(Azure.Messaging.CloudEvent[] cloudEvents) { throw null; }
        public static Azure.Communication.CallingServer.CallAutomationEventBase[] ParseMany(System.BinaryData json) { throw null; }
    }
    public static partial class CallAutomationModelFactory
    {
        public static Azure.Communication.CallingServer.AddParticipantsFailed AddParticipantsFailed(string operationContext = null, Azure.Communication.CallingServer.ResultInformation resultInformation = null, System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> participants = null, string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.AddParticipantsResult AddParticipantsResult(System.Collections.Generic.IEnumerable<Azure.Communication.CallingServer.CallParticipant> participants = null, string operationContext = null) { throw null; }
        public static Azure.Communication.CallingServer.AddParticipantsSucceeded AddParticipantsSucceeded(string operationContext = null, Azure.Communication.CallingServer.ResultInformation resultInformation = null, System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> participants = null, string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.AnswerCallResult AnswerCallResult(Azure.Communication.CallingServer.CallConnection callConnection = null, Azure.Communication.CallingServer.CallConnectionProperties callConnectionProperties = null) { throw null; }
        public static Azure.Communication.CallingServer.CallConnected CallConnected(string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.CallConnectionProperties CallConnectionProperties(string callConnectionId = null, string serverCallId = null, Azure.Communication.CallingServer.CallSource callSource = null, System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> targets = null, Azure.Communication.CallingServer.CallConnectionState callConnectionState = default(Azure.Communication.CallingServer.CallConnectionState), string subject = null, System.Uri callbackEndpoint = null, string mediaSubscriptionId = null) { throw null; }
        public static Azure.Communication.CallingServer.CallDisconnected CallDisconnected(string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.CallParticipant CallParticipant(Azure.Communication.CommunicationIdentifier identifier = null, bool isMuted = false) { throw null; }
        public static Azure.Communication.CallingServer.CallTransferAccepted CallTransferAccepted(string operationContext = null, Azure.Communication.CallingServer.ResultInformation resultInformation = null, string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.CallTransferFailed CallTransferFailed(string operationContext = null, Azure.Communication.CallingServer.ResultInformation resultInformation = null, string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.CreateCallResult CreateCallResult(Azure.Communication.CallingServer.CallConnection callConnection = null, Azure.Communication.CallingServer.CallConnectionProperties callConnectionProperties = null) { throw null; }
        public static Azure.Communication.CallingServer.ParticipantsUpdated ParticipantsUpdated(System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> participants = null, string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.PlayCompleted PlayCompleted(string operationContext = null, Azure.Communication.CallingServer.ResultInformation resultInformation = null, string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.PlayFailed PlayFailed(string operationContext = null, Azure.Communication.CallingServer.ResultInformation resultInformation = null, string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.RecognizeCompleted RecognizeCompleted(string operationContext = null, Azure.Communication.CallingServer.RecognitionType recognitionType = default(Azure.Communication.CallingServer.RecognitionType), Azure.Communication.CallingServer.CollectTonesResult collectTonesResult = null, Azure.Communication.CallingServer.ResultInformation resultInfo = null, string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.RecognizeFailed RecognizeFailed(string operationContext = null, Azure.Communication.CallingServer.ResultInformation resultInfo = null, string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.CallRecordingStateChanged RecordingStateChanged(string recordingId = null, Azure.Communication.CallingServer.RecordingState state = default(Azure.Communication.CallingServer.RecordingState), System.DateTimeOffset startDateTime = default(System.DateTimeOffset), string callConnectionId = null, string serverCallId = null, string correlationId = null) { throw null; }
        public static Azure.Communication.CallingServer.RecordingStateResult RecordingStateResult(string recordingId = null, Azure.Communication.CallingServer.RecordingState? recordingState = default(Azure.Communication.CallingServer.RecordingState?)) { throw null; }
        public static Azure.Communication.CallingServer.RemoveParticipantsResult RemoveParticipantsResult(string operationContext = null) { throw null; }
        public static Azure.Communication.CallingServer.ResultInformation ResultInformation(int? code = default(int?), int? subCode = default(int?), string message = null) { throw null; }
        public static Azure.Communication.CallingServer.TransferCallToParticipantResult TransferCallToParticipantResult(string operationContext = null) { throw null; }
    }
    public partial class CallConnected : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal CallConnected() { }
        public static Azure.Communication.CallingServer.CallConnected Deserialize(string content) { throw null; }
    }
    public partial class CallConnection
    {
        protected CallConnection() { }
        public virtual string CallConnectionId { get { throw null; } }
        public virtual Azure.Response<Azure.Communication.CallingServer.AddParticipantsResult> AddParticipants(System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> participantsToAdd, Azure.Communication.PhoneNumberIdentifier sourceCallerId = null, string operationContext = null, int? invitationTimeoutInSeconds = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.AddParticipantsResult>> AddParticipantsAsync(System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> participantsToAdd, Azure.Communication.PhoneNumberIdentifier sourceCallerId = null, string operationContext = null, int? invitationTimeoutInSeconds = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.CallingServer.CallConnectionProperties> GetCallConnectionProperties(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.CallConnectionProperties>> GetCallConnectionPropertiesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Communication.CallingServer.CallMedia GetCallMedia() { throw null; }
        public virtual Azure.Response<Azure.Communication.CallingServer.CallParticipant> GetParticipant(string participantMri, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.CallParticipant>> GetParticipantAsync(string participantMri, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.Communication.CallingServer.CallParticipant>> GetParticipants(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.Communication.CallingServer.CallParticipant>>> GetParticipantsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response HangUp(bool forEveryone, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> HangUpAsync(bool forEveryone, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.CallingServer.RemoveParticipantsResult> RemoveParticipants(System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> participantsToRemove, string operationContext = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.RemoveParticipantsResult>> RemoveParticipantsAsync(System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> participantsToRemove, string operationContext = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.CallingServer.TransferCallToParticipantResult> TransferCallToParticipant(Azure.Communication.CommunicationIdentifier targetParticipant, Azure.Communication.PhoneNumberIdentifier sourceCallerId = null, string userToUserInformation = null, string operationContext = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.TransferCallToParticipantResult>> TransferCallToParticipantAsync(Azure.Communication.CommunicationIdentifier targetParticipant, Azure.Communication.PhoneNumberIdentifier sourceCallerId = null, string userToUserInformation = null, string operationContext = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CallConnectionProperties
    {
        internal CallConnectionProperties() { }
        public System.Uri CallbackEndpoint { get { throw null; } }
        public string CallConnectionId { get { throw null; } }
        public Azure.Communication.CallingServer.CallConnectionState CallConnectionState { get { throw null; } }
        public Azure.Communication.CallingServer.CallSource CallSource { get { throw null; } }
        public string MediaSubscriptionId { get { throw null; } }
        public string ServerCallId { get { throw null; } }
        public string Subject { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.Communication.CommunicationIdentifier> Targets { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CallConnectionState : System.IEquatable<Azure.Communication.CallingServer.CallConnectionState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CallConnectionState(string value) { throw null; }
        public static Azure.Communication.CallingServer.CallConnectionState Connected { get { throw null; } }
        public static Azure.Communication.CallingServer.CallConnectionState Connecting { get { throw null; } }
        public static Azure.Communication.CallingServer.CallConnectionState Disconnected { get { throw null; } }
        public static Azure.Communication.CallingServer.CallConnectionState Disconnecting { get { throw null; } }
        public static Azure.Communication.CallingServer.CallConnectionState TransferAccepted { get { throw null; } }
        public static Azure.Communication.CallingServer.CallConnectionState Transferring { get { throw null; } }
        public static Azure.Communication.CallingServer.CallConnectionState Unknown { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.CallConnectionState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.CallConnectionState left, Azure.Communication.CallingServer.CallConnectionState right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.CallConnectionState (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.CallConnectionState left, Azure.Communication.CallingServer.CallConnectionState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CallDisconnected : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal CallDisconnected() { }
        public static Azure.Communication.CallingServer.CallDisconnected Deserialize(string content) { throw null; }
    }
    public abstract partial class CallLocator : System.IEquatable<Azure.Communication.CallingServer.CallLocator>
    {
        protected CallLocator() { }
        public string Id { get { throw null; } }
        public abstract bool Equals(Azure.Communication.CallingServer.CallLocator other);
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
    }
    public partial class CallMedia
    {
        protected CallMedia() { }
        public virtual string CallConnectionId { get { throw null; } }
        public virtual Azure.Response CancelAllMediaOperations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> CancelAllMediaOperationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Play(Azure.Communication.CallingServer.PlaySource playSource, System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> playTo, Azure.Communication.CallingServer.PlayOptions playOptions = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PlayAsync(Azure.Communication.CallingServer.PlaySource playSource, System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> playTo, Azure.Communication.CallingServer.PlayOptions playOptions = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response PlayToAll(Azure.Communication.CallingServer.PlaySource playSource, Azure.Communication.CallingServer.PlayOptions playOptions = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PlayToAllAsync(Azure.Communication.CallingServer.PlaySource playSource, Azure.Communication.CallingServer.PlayOptions playOptions = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response Recognize(Azure.Communication.CallingServer.RecognizeOptions recognizeOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> RecognizeAsync(Azure.Communication.CallingServer.RecognizeOptions recognizeOptions, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CallParticipant
    {
        internal CallParticipant() { }
        public Azure.Communication.CommunicationIdentifier Identifier { get { throw null; } }
        public bool IsMuted { get { throw null; } }
    }
    public partial class CallRecording
    {
        protected CallRecording() { }
        public virtual Azure.Response DeleteRecording(System.Uri recordingLocation, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteRecordingAsync(System.Uri recordingLocation, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<System.IO.Stream> DownloadStreaming(System.Uri sourceLocation, Azure.HttpRange range = default(Azure.HttpRange), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.IO.Stream>> DownloadStreamingAsync(System.Uri sourceLocation, Azure.HttpRange range = default(Azure.HttpRange), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DownloadTo(System.Uri sourceLocation, System.IO.Stream destinationStream, Azure.Communication.CallingServer.ContentTransferOptions transferOptions = default(Azure.Communication.CallingServer.ContentTransferOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DownloadTo(System.Uri sourceLocation, string destinationPath, Azure.Communication.CallingServer.ContentTransferOptions transferOptions = default(Azure.Communication.CallingServer.ContentTransferOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DownloadToAsync(System.Uri sourceLocation, System.IO.Stream destinationStream, Azure.Communication.CallingServer.ContentTransferOptions transferOptions = default(Azure.Communication.CallingServer.ContentTransferOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DownloadToAsync(System.Uri sourceLocation, string destinationPath, Azure.Communication.CallingServer.ContentTransferOptions transferOptions = default(Azure.Communication.CallingServer.ContentTransferOptions), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.CallingServer.RecordingStateResult> GetRecordingState(string recordingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.RecordingStateResult>> GetRecordingStateAsync(string recordingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response PauseRecording(string recordingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> PauseRecordingAsync(string recordingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response ResumeRecording(string recordingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> ResumeRecordingAsync(string recordingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.Communication.CallingServer.RecordingStateResult> StartRecording(Azure.Communication.CallingServer.StartRecordingOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.Communication.CallingServer.RecordingStateResult>> StartRecordingAsync(Azure.Communication.CallingServer.StartRecordingOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response StopRecording(string recordingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> StopRecordingAsync(string recordingId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class CallRecordingStateChanged : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal CallRecordingStateChanged() { }
        public string RecordingId { get { throw null; } }
        public System.DateTimeOffset? StartDateTime { get { throw null; } }
        public Azure.Communication.CallingServer.RecordingState State { get { throw null; } set { } }
        public static Azure.Communication.CallingServer.CallRecordingStateChanged Deserialize(string content) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CallRejectReason : System.IEquatable<Azure.Communication.CallingServer.CallRejectReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CallRejectReason(string value) { throw null; }
        public static Azure.Communication.CallingServer.CallRejectReason Busy { get { throw null; } }
        public static Azure.Communication.CallingServer.CallRejectReason Forbidden { get { throw null; } }
        public static Azure.Communication.CallingServer.CallRejectReason None { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.CallRejectReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.CallRejectReason left, Azure.Communication.CallingServer.CallRejectReason right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.CallRejectReason (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.CallRejectReason left, Azure.Communication.CallingServer.CallRejectReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CallSource
    {
        public CallSource(Azure.Communication.CommunicationIdentifier identifier) { }
        public Azure.Communication.PhoneNumberIdentifier CallerId { get { throw null; } set { } }
        public Azure.Communication.CommunicationIdentifier Identifier { get { throw null; } }
    }
    public partial class CallTransferAccepted : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal CallTransferAccepted() { }
        public string OperationContext { get { throw null; } }
        public Azure.Communication.CallingServer.ResultInformation ResultInfo { get { throw null; } }
        public static Azure.Communication.CallingServer.CallTransferAccepted Deserialize(string content) { throw null; }
    }
    public partial class CallTransferFailed : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal CallTransferFailed() { }
        public string OperationContext { get { throw null; } }
        public Azure.Communication.CallingServer.ResultInformation ResultInfo { get { throw null; } }
        public static Azure.Communication.CallingServer.CallTransferFailed Deserialize(string content) { throw null; }
    }
    public partial class ChannelAffinity
    {
        public ChannelAffinity() { }
        public int Channel { get { throw null; } set { } }
        public Azure.Communication.CommunicationIdentifier Participant { get { throw null; } set { } }
    }
    public partial class CollectTonesResult
    {
        internal CollectTonesResult() { }
        public System.Collections.Generic.IList<string> Tones { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ContentTransferOptions : System.IEquatable<Azure.Communication.CallingServer.ContentTransferOptions>
    {
        public long InitialTransferSize { get { throw null; } set { } }
        public int MaximumConcurrency { get { throw null; } set { } }
        public long MaximumTransferSize { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool Equals(Azure.Communication.CallingServer.ContentTransferOptions obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static bool operator ==(Azure.Communication.CallingServer.ContentTransferOptions left, Azure.Communication.CallingServer.ContentTransferOptions right) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static bool operator !=(Azure.Communication.CallingServer.ContentTransferOptions left, Azure.Communication.CallingServer.ContentTransferOptions right) { throw null; }
    }
    public partial class CreateCallOptions
    {
        public CreateCallOptions(Azure.Communication.CallingServer.CallSource source, System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> targets, System.Uri callbackEndpoint) { }
        public System.Uri CallbackEndpoint { get { throw null; } }
        public Azure.Communication.CallingServer.MediaStreamingConfiguration MediaStreamingConfiguration { get { throw null; } set { } }
        public Azure.Communication.CallingServer.CallSource Source { get { throw null; } }
        public string Subject { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Azure.Communication.CommunicationIdentifier> Targets { get { throw null; } }
    }
    public partial class CreateCallResult
    {
        internal CreateCallResult() { }
        public Azure.Communication.CallingServer.CallConnection CallConnection { get { throw null; } }
        public Azure.Communication.CallingServer.CallConnectionProperties CallConnectionProperties { get { throw null; } }
    }
    public partial class DtmfConfigurations
    {
        public DtmfConfigurations() { }
        public System.TimeSpan? InterToneTimeoutInSeconds { get { throw null; } set { } }
        public int? MaxTonesToCollect { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Azure.Communication.CallingServer.StopTones> StopTones { get { throw null; } set { } }
    }
    public partial class FileSource : Azure.Communication.CallingServer.PlaySource
    {
        public FileSource(System.Uri fileUri) { }
        public System.Uri FileUri { get { throw null; } }
    }
    public partial class GroupCallLocator : Azure.Communication.CallingServer.CallLocator
    {
        public GroupCallLocator(string id) { }
        public override bool Equals(Azure.Communication.CallingServer.CallLocator other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MediaStreamingAudioChannelType : System.IEquatable<Azure.Communication.CallingServer.MediaStreamingAudioChannelType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MediaStreamingAudioChannelType(string value) { throw null; }
        public static Azure.Communication.CallingServer.MediaStreamingAudioChannelType Mixed { get { throw null; } }
        public static Azure.Communication.CallingServer.MediaStreamingAudioChannelType Unmixed { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.MediaStreamingAudioChannelType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.MediaStreamingAudioChannelType left, Azure.Communication.CallingServer.MediaStreamingAudioChannelType right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.MediaStreamingAudioChannelType (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.MediaStreamingAudioChannelType left, Azure.Communication.CallingServer.MediaStreamingAudioChannelType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MediaStreamingConfiguration
    {
        public MediaStreamingConfiguration(System.Uri transportUrl, Azure.Communication.CallingServer.MediaStreamingTransportType transportType, Azure.Communication.CallingServer.MediaStreamingContentType contentType, Azure.Communication.CallingServer.MediaStreamingAudioChannelType audioChannelType) { }
        public Azure.Communication.CallingServer.MediaStreamingAudioChannelType AudioChannelType { get { throw null; } }
        public Azure.Communication.CallingServer.MediaStreamingContentType ContentType { get { throw null; } }
        public Azure.Communication.CallingServer.MediaStreamingTransportType TransportType { get { throw null; } }
        public System.Uri TransportUrl { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MediaStreamingContentType : System.IEquatable<Azure.Communication.CallingServer.MediaStreamingContentType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MediaStreamingContentType(string value) { throw null; }
        public static Azure.Communication.CallingServer.MediaStreamingContentType Audio { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.MediaStreamingContentType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.MediaStreamingContentType left, Azure.Communication.CallingServer.MediaStreamingContentType right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.MediaStreamingContentType (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.MediaStreamingContentType left, Azure.Communication.CallingServer.MediaStreamingContentType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MediaStreamingFormat
    {
        public MediaStreamingFormat() { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("channels")]
        public int Channels { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("encoding")]
        public string Encoding { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("length")]
        public double Length { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("sampleRate")]
        public int SampleRate { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct MediaStreamingTransportType : System.IEquatable<Azure.Communication.CallingServer.MediaStreamingTransportType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public MediaStreamingTransportType(string value) { throw null; }
        public static Azure.Communication.CallingServer.MediaStreamingTransportType Websocket { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.MediaStreamingTransportType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.MediaStreamingTransportType left, Azure.Communication.CallingServer.MediaStreamingTransportType right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.MediaStreamingTransportType (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.MediaStreamingTransportType left, Azure.Communication.CallingServer.MediaStreamingTransportType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ParticipantsUpdated : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal ParticipantsUpdated() { }
        public System.Collections.Generic.IReadOnlyList<Azure.Communication.CommunicationIdentifier> Participants { get { throw null; } }
        public static Azure.Communication.CallingServer.ParticipantsUpdated Deserialize(string content) { throw null; }
    }
    public partial class PlayCompleted : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal PlayCompleted() { }
        public string OperationContext { get { throw null; } }
        public Azure.Communication.CallingServer.ResultInformation ResultInfo { get { throw null; } }
        public static Azure.Communication.CallingServer.PlayCompleted Deserialize(string content) { throw null; }
    }
    public partial class PlayFailed : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal PlayFailed() { }
        public string OperationContext { get { throw null; } }
        public Azure.Communication.CallingServer.ResultInformation ResultInfo { get { throw null; } }
        public static Azure.Communication.CallingServer.PlayFailed Deserialize(string content) { throw null; }
    }
    public partial class PlayOptions
    {
        public PlayOptions() { }
        public bool Loop { get { throw null; } set { } }
        public string OperationContext { get { throw null; } set { } }
    }
    public abstract partial class PlaySource
    {
        protected PlaySource() { }
        public string PlaySourceId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RecognitionType : System.IEquatable<Azure.Communication.CallingServer.RecognitionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RecognitionType(string value) { throw null; }
        public static Azure.Communication.CallingServer.RecognitionType Dtmf { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.RecognitionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.RecognitionType left, Azure.Communication.CallingServer.RecognitionType right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.RecognitionType (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.RecognitionType left, Azure.Communication.CallingServer.RecognitionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RecognizeCompleted : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal RecognizeCompleted() { }
        public Azure.Communication.CallingServer.CollectTonesResult CollectTonesResult { get { throw null; } }
        public string OperationContext { get { throw null; } }
        public Azure.Communication.CallingServer.RecognitionType RecognitionType { get { throw null; } set { } }
        public Azure.Communication.CallingServer.ResultInformation ResultInfo { get { throw null; } }
        public static Azure.Communication.CallingServer.RecognizeCompleted Deserialize(string content) { throw null; }
    }
    public partial class RecognizeConfigurations
    {
        public RecognizeConfigurations() { }
        public Azure.Communication.CallingServer.DtmfConfigurations DtmfConfigurations { get { throw null; } set { } }
        public System.TimeSpan? InitialSilenceTimeoutInSeconds { get { throw null; } set { } }
        public bool? InterruptPromptAndStartRecognition { get { throw null; } set { } }
        public Azure.Communication.CommunicationIdentifier TargetParticipant { get { throw null; } set { } }
    }
    public partial class RecognizeFailed : Azure.Communication.CallingServer.CallAutomationEventBase
    {
        internal RecognizeFailed() { }
        public string OperationContext { get { throw null; } }
        public Azure.Communication.CallingServer.ResultInformation ResultInfo { get { throw null; } }
        public static Azure.Communication.CallingServer.RecognizeFailed Deserialize(string content) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RecognizeInputType : System.IEquatable<Azure.Communication.CallingServer.RecognizeInputType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RecognizeInputType(string value) { throw null; }
        public static Azure.Communication.CallingServer.RecognizeInputType Dtmf { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.RecognizeInputType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.RecognizeInputType left, Azure.Communication.CallingServer.RecognizeInputType right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.RecognizeInputType (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.RecognizeInputType left, Azure.Communication.CallingServer.RecognizeInputType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RecognizeOptions
    {
        public RecognizeOptions(Azure.Communication.CallingServer.RecognizeInputType recognizeInputType, Azure.Communication.CallingServer.RecognizeConfigurations recognizeConfigurations) { }
        public string OperationContext { get { throw null; } set { } }
        public Azure.Communication.CallingServer.PlaySource Prompt { get { throw null; } set { } }
        public Azure.Communication.CallingServer.RecognizeConfigurations RecognizeConfigurations { get { throw null; } }
        public Azure.Communication.CallingServer.RecognizeInputType RecognizeInputType { get { throw null; } }
        public bool? StopCurrentOperations { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RecordingChannel : System.IEquatable<Azure.Communication.CallingServer.RecordingChannel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RecordingChannel(string value) { throw null; }
        public static Azure.Communication.CallingServer.RecordingChannel Mixed { get { throw null; } }
        public static Azure.Communication.CallingServer.RecordingChannel Unmixed { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.RecordingChannel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.RecordingChannel left, Azure.Communication.CallingServer.RecordingChannel right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.RecordingChannel (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.RecordingChannel left, Azure.Communication.CallingServer.RecordingChannel right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RecordingContent : System.IEquatable<Azure.Communication.CallingServer.RecordingContent>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RecordingContent(string value) { throw null; }
        public static Azure.Communication.CallingServer.RecordingContent Audio { get { throw null; } }
        public static Azure.Communication.CallingServer.RecordingContent AudioVideo { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.RecordingContent other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.RecordingContent left, Azure.Communication.CallingServer.RecordingContent right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.RecordingContent (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.RecordingContent left, Azure.Communication.CallingServer.RecordingContent right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RecordingFormat : System.IEquatable<Azure.Communication.CallingServer.RecordingFormat>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RecordingFormat(string value) { throw null; }
        public static Azure.Communication.CallingServer.RecordingFormat Mp3 { get { throw null; } }
        public static Azure.Communication.CallingServer.RecordingFormat Mp4 { get { throw null; } }
        public static Azure.Communication.CallingServer.RecordingFormat Wav { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.RecordingFormat other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.RecordingFormat left, Azure.Communication.CallingServer.RecordingFormat right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.RecordingFormat (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.RecordingFormat left, Azure.Communication.CallingServer.RecordingFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct RecordingState : System.IEquatable<Azure.Communication.CallingServer.RecordingState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public RecordingState(string value) { throw null; }
        public static Azure.Communication.CallingServer.RecordingState Active { get { throw null; } }
        public static Azure.Communication.CallingServer.RecordingState Inactive { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.RecordingState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.RecordingState left, Azure.Communication.CallingServer.RecordingState right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.RecordingState (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.RecordingState left, Azure.Communication.CallingServer.RecordingState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class RecordingStateResult
    {
        internal RecordingStateResult() { }
        public string RecordingId { get { throw null; } }
        public Azure.Communication.CallingServer.RecordingState? RecordingState { get { throw null; } }
    }
    public partial class RemoveParticipantsResult
    {
        internal RemoveParticipantsResult() { }
        public string OperationContext { get { throw null; } }
    }
    public partial class ResultInformation
    {
        internal ResultInformation() { }
        public int? Code { get { throw null; } }
        public string Message { get { throw null; } }
        public int? SubCode { get { throw null; } }
    }
    public partial class ServerCallLocator : Azure.Communication.CallingServer.CallLocator
    {
        public ServerCallLocator(string id) { }
        public override bool Equals(Azure.Communication.CallingServer.CallLocator other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class StartRecordingOptions
    {
        public StartRecordingOptions(Azure.Communication.CallingServer.CallLocator callLocator) { }
        public System.Collections.Generic.IEnumerable<Azure.Communication.CallingServer.ChannelAffinity> ChannelAffinity { get { throw null; } set { } }
        public Azure.Communication.CallingServer.RecordingChannel RecordingChannel { get { throw null; } set { } }
        public Azure.Communication.CallingServer.RecordingContent RecordingContent { get { throw null; } set { } }
        public Azure.Communication.CallingServer.RecordingFormat RecordingFormat { get { throw null; } set { } }
        public System.Uri RecordingStateCallbackEndpoint { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct StopTones : System.IEquatable<Azure.Communication.CallingServer.StopTones>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public StopTones(string value) { throw null; }
        public static Azure.Communication.CallingServer.StopTones A { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Asterisk { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones B { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones C { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones D { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Eight { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Five { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Four { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Nine { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones One { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Pound { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Seven { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Six { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Three { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Two { get { throw null; } }
        public static Azure.Communication.CallingServer.StopTones Zero { get { throw null; } }
        public bool Equals(Azure.Communication.CallingServer.StopTones other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.Communication.CallingServer.StopTones left, Azure.Communication.CallingServer.StopTones right) { throw null; }
        public static implicit operator Azure.Communication.CallingServer.StopTones (string value) { throw null; }
        public static bool operator !=(Azure.Communication.CallingServer.StopTones left, Azure.Communication.CallingServer.StopTones right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TransferCallToParticipantResult
    {
        internal TransferCallToParticipantResult() { }
        public string OperationContext { get { throw null; } }
    }
}
namespace Azure.Communication.CallingServer.Models.Streaming
{
    public partial class MediaStreamingAudio
    {
        public MediaStreamingAudio() { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("data")]
        public byte[] Data { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("isSilence")]
        public bool IsSilence { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("participantId")]
        public string ParticipantId { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("timestamp")]
        public System.DateTime Timestamp { get { throw null; } set { } }
    }
    public partial class MediaStreamingMetadata
    {
        public MediaStreamingMetadata() { }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("format")]
        public Azure.Communication.CallingServer.MediaStreamingFormat Format { get { throw null; } set { } }
        [System.Text.Json.Serialization.JsonPropertyNameAttribute("subscriptionId")]
        public string SubscriptionId { get { throw null; } set { } }
    }
}
