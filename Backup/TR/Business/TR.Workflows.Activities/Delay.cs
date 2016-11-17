//====================================================================================================
// Base code generated with Vector: WFA Gen (Build 3.0.5701.25371)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by es.cheah at ENGSOON on 11/15/2016 07:32:26 
//====================================================================================================

using System;
using System.Activities;
using System.Collections.Generic;
using TR.Entities;
using TR.Business;

namespace TR.Workflows.Activities
{
    /// <summary>
    /// Delay workflow activity.
    /// </summary>
    [Serializable]
    public sealed class Delay : CodeActivity
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
            trainingComponent.Delay(trainingRequest);
        }
    }
}
