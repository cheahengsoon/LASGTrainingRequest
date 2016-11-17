//====================================================================================================
// Base code generated with Vector: WFA Gen (Build 3.0.5701.25371)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by es.cheah at ENGSOON on 11/09/2016 14:34:43 
//====================================================================================================

using System;
using System.Activities;
using System.Collections.Generic;
using TR.Entities;
using TR.Business;

namespace TR.Workflows.Activities
{
    /// <summary>
    /// Approve workflow activity.
    /// </summary>
    [Serializable]
    public sealed class Approve : CodeActivity
    {
        // Argument declaration.
        public InArgument<TrainingRequest> TrainingRequest { get; set; }

        protected override void Execute(CodeActivityContext context)
        {

            // Argument initialization (if any).
            TrainingRequest trainingRequest = context.GetValue(this.TrainingRequest);

            // Instantiate business components.
            var trainingComponent = new TrainingComponent();

            // Call business component methods.
            trainingComponent.Approve(trainingRequest);
        }
    }
}
