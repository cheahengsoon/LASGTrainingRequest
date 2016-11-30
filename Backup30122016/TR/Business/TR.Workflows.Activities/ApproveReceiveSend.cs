//====================================================================================================
// Base code generated with Vector: WFA Gen (Build 3.0.5701.25371)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by es.cheah at ENGSOON on 11/09/2016 14:34:43 
//====================================================================================================

using System;
using System.Activities;
using System.Activities.Presentation;
using System.Activities.Statements;
using System.Net.Security;
using System.ServiceModel.Activities;
using System.Windows;
using System.Collections.Generic;
using TR.Entities;
using TR.Business;

namespace TR.Workflows.Activities
{
    /// <summary>
    /// Messaging wrapper activity for Approve.
    /// </summary>
    /// <remarks>
    /// This class serves only as a convenience to simplify workflow services creation at
    /// design time. It does not contribute any functionality to running code.
    /// </remarks>
    public class ApproveReceiveSend : MessagingWrapperActivity, IActivityTemplateFactory
    {
        public Activity Create(DependencyObject target)
        {
            // Sequence container.
            var sequence = new Sequence();
            sequence.DisplayName = "Approve";

            // Correlation Handle.
            var handle = new Variable<CorrelationHandle>("_handle");
            var trainingRequest = new Variable<TrainingRequest>("_trainingRequest");

            // Get variable collection.
            var variables = GetVariableCollection(target);

            if (variables == null)
            {
                sequence.Variables.Add(handle);
                sequence.Variables.Add(trainingRequest);
            }
            else
            {
                handle = AddVariable<CorrelationHandle>(variables, handle);
                trainingRequest = AddVariable<TrainingRequest>(variables, trainingRequest);
            }

            // Create Receive Activity.
            var receive = new Receive();
            receive.DisplayName = "Approve Receive";
            receive.Action = "http://tempuri.org/ITrainingWorkflowService/Approve";
            receive.OperationName = "Approve";
            receive.ProtectionLevel = ProtectionLevel.None;
            receive.ServiceContractName = "ITrainingWorkflowService";
            receive.CanCreateInstance = true;

            // Add parameters to Receive
            var parameters = new ReceiveParametersContent();
            parameters.Parameters.Add("trainingRequest", new OutArgument<TrainingRequest>(trainingRequest));
            receive.Content = parameters;

            // Add CorrelationInitializer to Receive
            var initializer = new RequestReplyCorrelationInitializer();
            initializer.CorrelationHandle = new InArgument<CorrelationHandle>(handle);
            receive.CorrelationInitializers.Add(initializer);

            // Create SendReply Activity
            var send = new SendReply();
            send.DisplayName = "Approve Reply";
            send.Action = "http://tempuri.org/ITrainingWorkflowService/ApproveResponse";
            send.Request = receive;
            send.PersistBeforeSend = true;

            // Create Approve activity.
            Approve approve = new Approve();
            approve.DisplayName = "Approve";
            approve.TrainingRequest = trainingRequest;

            // Add activities to sequence.
            sequence.Activities.Add(receive);
            sequence.Activities.Add(approve);
            sequence.Activities.Add(send);

            return sequence;
        }
    }
}
