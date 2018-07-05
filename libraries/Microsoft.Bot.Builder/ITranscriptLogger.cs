﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Microsoft.Bot.Schema;

namespace Microsoft.Bot.Builder
{
    /// <summary>
    /// Transcript logger stores activities for conversations for recall
    /// </summary>
    public interface ITranscriptLogger
    {
        /// <summary>
        /// Log an activity to the transcript
        /// </summary>
        /// <param name="activity"></param>
        /// <returns></returns>
        Task LogActivityAsync(IActivity activity);
    }
}