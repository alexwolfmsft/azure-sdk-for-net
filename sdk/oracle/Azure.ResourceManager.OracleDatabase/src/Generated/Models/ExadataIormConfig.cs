// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    /// <summary>
    /// ExadataIormConfig for cloud vm cluster
    /// Serialized Name: ExadataIormConfig
    /// </summary>
    public partial class ExadataIormConfig
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExadataIormConfig"/>. </summary>
        internal ExadataIormConfig()
        {
            DbPlans = new ChangeTrackingList<DbIormConfig>();
        }

        /// <summary> Initializes a new instance of <see cref="ExadataIormConfig"/>. </summary>
        /// <param name="dbPlans">
        /// An array of IORM settings for all the database in the Exadata DB system.
        /// Serialized Name: ExadataIormConfig.dbPlans
        /// </param>
        /// <param name="lifecycleDetails">
        /// Additional information about the current lifecycleState.
        /// Serialized Name: ExadataIormConfig.lifecycleDetails
        /// </param>
        /// <param name="lifecycleState">
        /// The current state of IORM configuration for the Exadata DB system.
        /// Serialized Name: ExadataIormConfig.lifecycleState
        /// </param>
        /// <param name="objective">
        /// The current value for the IORM objective. The default is AUTO.
        /// Serialized Name: ExadataIormConfig.objective
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExadataIormConfig(IReadOnlyList<DbIormConfig> dbPlans, string lifecycleDetails, IormLifecycleState? lifecycleState, Objective? objective, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DbPlans = dbPlans;
            LifecycleDetails = lifecycleDetails;
            LifecycleState = lifecycleState;
            Objective = objective;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// An array of IORM settings for all the database in the Exadata DB system.
        /// Serialized Name: ExadataIormConfig.dbPlans
        /// </summary>
        public IReadOnlyList<DbIormConfig> DbPlans { get; }
        /// <summary>
        /// Additional information about the current lifecycleState.
        /// Serialized Name: ExadataIormConfig.lifecycleDetails
        /// </summary>
        public string LifecycleDetails { get; }
        /// <summary>
        /// The current state of IORM configuration for the Exadata DB system.
        /// Serialized Name: ExadataIormConfig.lifecycleState
        /// </summary>
        public IormLifecycleState? LifecycleState { get; }
        /// <summary>
        /// The current value for the IORM objective. The default is AUTO.
        /// Serialized Name: ExadataIormConfig.objective
        /// </summary>
        public Objective? Objective { get; }
    }
}
