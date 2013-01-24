/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Describe Stemming Options Request Marshaller
    /// </summary>       
    public class DescribeStemmingOptionsRequestMarshaller : IMarshaller<IRequest, DescribeStemmingOptionsRequest>
    {
        public IRequest Marshall(DescribeStemmingOptionsRequest describeStemmingOptionsRequest)
        {
            IRequest request = new DefaultRequest(describeStemmingOptionsRequest, "AmazonCloudSearch");
            request.Parameters.Add("Action", "DescribeStemmingOptions");
            request.Parameters.Add("Version", "2011-02-01");
            if (describeStemmingOptionsRequest != null && describeStemmingOptionsRequest.IsSetDomainName())
            {
                request.Parameters.Add("DomainName", StringUtils.FromString(describeStemmingOptionsRequest.DomainName));
            }

            return request;
        }
    }
}
