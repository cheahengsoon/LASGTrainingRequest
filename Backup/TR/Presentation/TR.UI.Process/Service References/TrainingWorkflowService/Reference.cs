﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TR.UI.Process.TrainingWorkflowService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TrainingWorkflowService.ITrainingWorkflowService")]
    public interface ITrainingWorkflowService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingWorkflowService/Apply", ReplyAction="http://tempuri.org/ITrainingWorkflowService/ApplyResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ApplyResponseResult")]
        TR.Entities.TrainingRequest Apply(TR.Entities.TrainingRequest trainingRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingWorkflowService/Apply", ReplyAction="http://tempuri.org/ITrainingWorkflowService/ApplyResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="ApplyResponseResult")]
        System.Threading.Tasks.Task<TR.Entities.TrainingRequest> ApplyAsync(TR.Entities.TrainingRequest trainingRequest);
        
        // CODEGEN: Generating message contract since the operation Approve is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingWorkflowService/Approve", ReplyAction="http://tempuri.org/ITrainingWorkflowService/ApproveResponse")]
        TR.UI.Process.TrainingWorkflowService.ApproveResponse Approve(TR.UI.Process.TrainingWorkflowService.ApproveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingWorkflowService/Approve", ReplyAction="http://tempuri.org/ITrainingWorkflowService/ApproveResponse")]
        System.Threading.Tasks.Task<TR.UI.Process.TrainingWorkflowService.ApproveResponse> ApproveAsync(TR.UI.Process.TrainingWorkflowService.ApproveRequest request);
        
        // CODEGEN: Generating message contract since the operation Cancel is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingWorkflowService/Cancel", ReplyAction="http://tempuri.org/ITrainingWorkflowService/CancelResponse")]
        TR.UI.Process.TrainingWorkflowService.CancelResponse Cancel(TR.UI.Process.TrainingWorkflowService.CancelRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingWorkflowService/Cancel", ReplyAction="http://tempuri.org/ITrainingWorkflowService/CancelResponse")]
        System.Threading.Tasks.Task<TR.UI.Process.TrainingWorkflowService.CancelResponse> CancelAsync(TR.UI.Process.TrainingWorkflowService.CancelRequest request);
        
        // CODEGEN: Generating message contract since the operation Reject is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingWorkflowService/Reject", ReplyAction="http://tempuri.org/ITrainingWorkflowService/RejectResponse")]
        TR.UI.Process.TrainingWorkflowService.RejectResponse Reject(TR.UI.Process.TrainingWorkflowService.RejectRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITrainingWorkflowService/Reject", ReplyAction="http://tempuri.org/ITrainingWorkflowService/RejectResponse")]
        System.Threading.Tasks.Task<TR.UI.Process.TrainingWorkflowService.RejectResponse> RejectAsync(TR.UI.Process.TrainingWorkflowService.RejectRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Approve", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ApproveRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public TR.Entities.TrainingRequest trainingRequest;
        
        public ApproveRequest() {
        }
        
        public ApproveRequest(TR.Entities.TrainingRequest trainingRequest) {
            this.trainingRequest = trainingRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ApproveResponse {
        
        public ApproveResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Cancel", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CancelRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public TR.Entities.TrainingRequest trainingRequest;
        
        public CancelRequest() {
        }
        
        public CancelRequest(TR.Entities.TrainingRequest trainingRequest) {
            this.trainingRequest = trainingRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CancelResponse {
        
        public CancelResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Reject", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class RejectRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public TR.Entities.TrainingRequest trainingRequest;
        
        public RejectRequest() {
        }
        
        public RejectRequest(TR.Entities.TrainingRequest trainingRequest) {
            this.trainingRequest = trainingRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class RejectResponse {
        
        public RejectResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITrainingWorkflowServiceChannel : TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TrainingWorkflowServiceClient : System.ServiceModel.ClientBase<TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService>, TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService {
        
        public TrainingWorkflowServiceClient() {
        }
        
        public TrainingWorkflowServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TrainingWorkflowServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrainingWorkflowServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrainingWorkflowServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TR.Entities.TrainingRequest Apply(TR.Entities.TrainingRequest trainingRequest) {
            return base.Channel.Apply(trainingRequest);
        }
        
        public System.Threading.Tasks.Task<TR.Entities.TrainingRequest> ApplyAsync(TR.Entities.TrainingRequest trainingRequest) {
            return base.Channel.ApplyAsync(trainingRequest);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TR.UI.Process.TrainingWorkflowService.ApproveResponse TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService.Approve(TR.UI.Process.TrainingWorkflowService.ApproveRequest request) {
            return base.Channel.Approve(request);
        }
        
        public void Approve(TR.Entities.TrainingRequest trainingRequest) {
            TR.UI.Process.TrainingWorkflowService.ApproveRequest inValue = new TR.UI.Process.TrainingWorkflowService.ApproveRequest();
            inValue.trainingRequest = trainingRequest;
            TR.UI.Process.TrainingWorkflowService.ApproveResponse retVal = ((TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService)(this)).Approve(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TR.UI.Process.TrainingWorkflowService.ApproveResponse> TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService.ApproveAsync(TR.UI.Process.TrainingWorkflowService.ApproveRequest request) {
            return base.Channel.ApproveAsync(request);
        }
        
        public System.Threading.Tasks.Task<TR.UI.Process.TrainingWorkflowService.ApproveResponse> ApproveAsync(TR.Entities.TrainingRequest trainingRequest) {
            TR.UI.Process.TrainingWorkflowService.ApproveRequest inValue = new TR.UI.Process.TrainingWorkflowService.ApproveRequest();
            inValue.trainingRequest = trainingRequest;
            return ((TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService)(this)).ApproveAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TR.UI.Process.TrainingWorkflowService.CancelResponse TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService.Cancel(TR.UI.Process.TrainingWorkflowService.CancelRequest request) {
            return base.Channel.Cancel(request);
        }
        
        public void Cancel(TR.Entities.TrainingRequest trainingRequest) {
            TR.UI.Process.TrainingWorkflowService.CancelRequest inValue = new TR.UI.Process.TrainingWorkflowService.CancelRequest();
            inValue.trainingRequest = trainingRequest;
            TR.UI.Process.TrainingWorkflowService.CancelResponse retVal = ((TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService)(this)).Cancel(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TR.UI.Process.TrainingWorkflowService.CancelResponse> TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService.CancelAsync(TR.UI.Process.TrainingWorkflowService.CancelRequest request) {
            return base.Channel.CancelAsync(request);
        }
        
        public System.Threading.Tasks.Task<TR.UI.Process.TrainingWorkflowService.CancelResponse> CancelAsync(TR.Entities.TrainingRequest trainingRequest) {
            TR.UI.Process.TrainingWorkflowService.CancelRequest inValue = new TR.UI.Process.TrainingWorkflowService.CancelRequest();
            inValue.trainingRequest = trainingRequest;
            return ((TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService)(this)).CancelAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TR.UI.Process.TrainingWorkflowService.RejectResponse TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService.Reject(TR.UI.Process.TrainingWorkflowService.RejectRequest request) {
            return base.Channel.Reject(request);
        }
        
        public void Reject(TR.Entities.TrainingRequest trainingRequest) {
            TR.UI.Process.TrainingWorkflowService.RejectRequest inValue = new TR.UI.Process.TrainingWorkflowService.RejectRequest();
            inValue.trainingRequest = trainingRequest;
            TR.UI.Process.TrainingWorkflowService.RejectResponse retVal = ((TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService)(this)).Reject(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TR.UI.Process.TrainingWorkflowService.RejectResponse> TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService.RejectAsync(TR.UI.Process.TrainingWorkflowService.RejectRequest request) {
            return base.Channel.RejectAsync(request);
        }
        
        public System.Threading.Tasks.Task<TR.UI.Process.TrainingWorkflowService.RejectResponse> RejectAsync(TR.Entities.TrainingRequest trainingRequest) {
            TR.UI.Process.TrainingWorkflowService.RejectRequest inValue = new TR.UI.Process.TrainingWorkflowService.RejectRequest();
            inValue.trainingRequest = trainingRequest;
            return ((TR.UI.Process.TrainingWorkflowService.ITrainingWorkflowService)(this)).RejectAsync(inValue);
        }
    }
}
