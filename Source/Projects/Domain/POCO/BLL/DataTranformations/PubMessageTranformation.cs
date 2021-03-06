// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Linq;
using System.Collections.Generic;
using log4net;
using System.Collections.ObjectModel;
using System.Data;

namespace DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessageDataTransformation
{
    public class Transformer
    {

        #region Transformation 'PubMessage_To_PubMessage'





        // Left To Right

        private readonly Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage, DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage> PubMessage_To_PubMessage_Transformations = new Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage, DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage>();
        public DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage PubMessage_To_PubMessage(DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage domainPubMessageInput)
        {
            //Leave, if there is nothing to transform
            if(domainPubMessageInput == null) return default(DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage);
            // If the same Transformation has already ran, get the stored Output and return
            if(PubMessage_To_PubMessage_Transformations.ContainsKey(domainPubMessageInput))
            {
                return PubMessage_To_PubMessage_Transformations[domainPubMessageInput];
            }
            // Instantiate target root
            var interfacesLocalPubSubPubMessageOutput = new DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage();
            PubMessage_To_PubMessage_Transformations.Add(domainPubMessageInput, interfacesLocalPubSubPubMessageOutput);
            // PubMessage.key to PubMessage.key
            interfacesLocalPubSubPubMessageOutput.key = domainPubMessageInput?.key;
            // PubMessage.val to PubMessage.val
            interfacesLocalPubSubPubMessageOutput.val = domainPubMessageInput?.val;
            // PubMessage.type to PubMessage.type
            interfacesLocalPubSubPubMessageOutput.type = domainPubMessageInput?.type;
            return interfacesLocalPubSubPubMessageOutput;
        }

        // Left To Right with Existing Instance

        private readonly Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage, DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage> PubMessage_To_PubMessage_MappingTransformations = new Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage, DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage>();
        public DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage PubMessage_To_PubMessage(DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage domainPubMessageInput, DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage interfacesLocalPubSubPubMessageInstance)
        {
            //Leave, if there is nothing to transform
            if(domainPubMessageInput == null) return default(DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage);
            if(interfacesLocalPubSubPubMessageInstance == null)
                return PubMessage_To_PubMessage (domainPubMessageInput);
            // If the same Transformation has already ran, get the stored Output and return
            if(PubMessage_To_PubMessage_MappingTransformations.ContainsKey(domainPubMessageInput))
            {
                return PubMessage_To_PubMessage_MappingTransformations[domainPubMessageInput];
            }
            // Instantiate target root
            var interfacesLocalPubSubPubMessageOutput = interfacesLocalPubSubPubMessageInstance;
            PubMessage_To_PubMessage_MappingTransformations.Add(domainPubMessageInput, interfacesLocalPubSubPubMessageOutput);
            // PubMessage.key to PubMessage.key
            interfacesLocalPubSubPubMessageOutput.key = domainPubMessageInput?.key;
            // PubMessage.val to PubMessage.val
            interfacesLocalPubSubPubMessageOutput.val = domainPubMessageInput?.val;
            // PubMessage.type to PubMessage.type
            interfacesLocalPubSubPubMessageOutput.type = domainPubMessageInput?.type;
            return interfacesLocalPubSubPubMessageOutput;
        }

        // Right To Left

        private readonly Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage, DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage> PubMessage_To_PubMessageReversed_Transformations = new Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage, DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage>();
        public DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage PubMessage_To_PubMessageReversed(DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage interfacesLocalPubSubPubMessageInput)
        {
            //Leave, if there is nothing to transform
            if(interfacesLocalPubSubPubMessageInput == null) return default(DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage);
            // If the same Transformation has already ran, get the stored Output and return
            if(PubMessage_To_PubMessageReversed_Transformations.ContainsKey(interfacesLocalPubSubPubMessageInput))
            {
                return PubMessage_To_PubMessageReversed_Transformations[interfacesLocalPubSubPubMessageInput];
            }
            // Instantiate target root
            var domainPubMessageOutput = new DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage();
            PubMessage_To_PubMessageReversed_Transformations.Add(interfacesLocalPubSubPubMessageInput, domainPubMessageOutput);
            // PubMessage.key to PubMessage.key
            domainPubMessageOutput.key = interfacesLocalPubSubPubMessageInput?.key;
            // PubMessage.val to PubMessage.val
            domainPubMessageOutput.val = interfacesLocalPubSubPubMessageInput?.val;
            // PubMessage.type to PubMessage.type
            domainPubMessageOutput.type = interfacesLocalPubSubPubMessageInput?.type;
            return domainPubMessageOutput;
        }

        // Right To Left with Existing Instance

        private readonly Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage, DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage> PubMessage_To_PubMessageReversed_MappingTransformations = new Dictionary<DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage, DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage>();
        public DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage PubMessage_To_PubMessageReversed(DSS3_LogisticsPoolingForUrbanDistribution.ExternalStructs.LocalPubSub.PubMessage interfacesLocalPubSubPubMessageInput, DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage domainPubMessageInstance)
        {
            //Leave, if there is nothing to transform
            if(interfacesLocalPubSubPubMessageInput == null) return default(DSS3_LogisticsPoolingForUrbanDistribution.BO.PubMessage);
            if(domainPubMessageInstance == null)
                return PubMessage_To_PubMessageReversed (interfacesLocalPubSubPubMessageInput);
            // If the same Transformation has already ran, get the stored Output and return
            if(PubMessage_To_PubMessageReversed_MappingTransformations.ContainsKey(interfacesLocalPubSubPubMessageInput))
            {
                return PubMessage_To_PubMessageReversed_MappingTransformations[interfacesLocalPubSubPubMessageInput];
            }
            // Instantiate target root
            var domainPubMessageOutput = domainPubMessageInstance;
            PubMessage_To_PubMessageReversed_MappingTransformations.Add(interfacesLocalPubSubPubMessageInput, domainPubMessageOutput);
            // PubMessage.key to PubMessage.key
            domainPubMessageOutput.key = interfacesLocalPubSubPubMessageInput?.key;
            // PubMessage.val to PubMessage.val
            domainPubMessageOutput.val = interfacesLocalPubSubPubMessageInput?.val;
            // PubMessage.type to PubMessage.type
            domainPubMessageOutput.type = interfacesLocalPubSubPubMessageInput?.type;
            return domainPubMessageOutput;
        }

        #endregion

    }
}