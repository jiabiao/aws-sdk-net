/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GuardDuty.Model;

namespace Amazon.GuardDuty
{
    /// <summary>
    /// Interface for accessing GuardDuty
    ///
    /// Amazon GuardDuty is a continuous security monitoring service that analyzes and processes
    /// the following data sources: VPC Flow Logs, AWS CloudTrail event logs, and DNS logs.
    /// It uses threat intelligence feeds, such as lists of malicious IPs and domains, and
    /// machine learning to identify unexpected and potentially unauthorized and malicious
    /// activity within your AWS environment. This can include issues like escalations of
    /// privileges, uses of exposed credentials, or communication with malicious IPs, URLs,
    /// or domains. For example, GuardDuty can detect compromised EC2 instances serving malware
    /// or mining bitcoin. It also monitors AWS account access behavior for signs of compromise,
    /// such as unauthorized infrastructure deployments, like instances deployed in a region
    /// that has never been used, or unusual API calls, like a password policy change to reduce
    /// password strength. GuardDuty informs you of the status of your AWS environment by
    /// producing security findings that you can view in the GuardDuty console or through
    /// Amazon CloudWatch events. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/what-is-guardduty.html">
    /// Amazon GuardDuty User Guide</a>.
    /// </summary>
    public partial interface IAmazonGuardDuty : IAmazonService, IDisposable
    {

        
        #region  AcceptInvitation


        /// <summary>
        /// Accepts the invitation to be monitored by a master GuardDuty account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request);



        /// <summary>
        /// Accepts the invitation to be monitored by a master GuardDuty account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        Task<AcceptInvitationResponse> AcceptInvitationAsync(AcceptInvitationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ArchiveFindings


        /// <summary>
        /// Archives GuardDuty findings specified by the list of finding IDs.
        /// 
        ///  <note> 
        /// <para>
        /// Only the master account can archive findings. Member accounts do not have permission
        /// to archive findings from their accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveFindings service method.</param>
        /// 
        /// <returns>The response from the ArchiveFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ArchiveFindings">REST API Reference for ArchiveFindings Operation</seealso>
        ArchiveFindingsResponse ArchiveFindings(ArchiveFindingsRequest request);



        /// <summary>
        /// Archives GuardDuty findings specified by the list of finding IDs.
        /// 
        ///  <note> 
        /// <para>
        /// Only the master account can archive findings. Member accounts do not have permission
        /// to archive findings from their accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ArchiveFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ArchiveFindings">REST API Reference for ArchiveFindings Operation</seealso>
        Task<ArchiveFindingsResponse> ArchiveFindingsAsync(ArchiveFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDetector


        /// <summary>
        /// Creates a single Amazon GuardDuty detector. A detector is a resource that represents
        /// the GuardDuty service. To start using GuardDuty, you must create a detector in each
        /// region that you enable the service. You can have only one detector per account per
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetector service method.</param>
        /// 
        /// <returns>The response from the CreateDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateDetector">REST API Reference for CreateDetector Operation</seealso>
        CreateDetectorResponse CreateDetector(CreateDetectorRequest request);



        /// <summary>
        /// Creates a single Amazon GuardDuty detector. A detector is a resource that represents
        /// the GuardDuty service. To start using GuardDuty, you must create a detector in each
        /// region that you enable the service. You can have only one detector per account per
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateDetector">REST API Reference for CreateDetector Operation</seealso>
        Task<CreateDetectorResponse> CreateDetectorAsync(CreateDetectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFilter


        /// <summary>
        /// Creates a filter using the specified finding criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        CreateFilterResponse CreateFilter(CreateFilterRequest request);



        /// <summary>
        /// Creates a filter using the specified finding criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateFilter">REST API Reference for CreateFilter Operation</seealso>
        Task<CreateFilterResponse> CreateFilterAsync(CreateFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateIPSet


        /// <summary>
        /// Creates a new IPSet - a list of trusted IP addresses that have been whitelisted for
        /// secure communication with AWS infrastructure and applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        CreateIPSetResponse CreateIPSet(CreateIPSetRequest request);



        /// <summary>
        /// Creates a new IPSet - a list of trusted IP addresses that have been whitelisted for
        /// secure communication with AWS infrastructure and applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateIPSet">REST API Reference for CreateIPSet Operation</seealso>
        Task<CreateIPSetResponse> CreateIPSetAsync(CreateIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMembers


        /// <summary>
        /// Creates member accounts of the current AWS account by specifying a list of AWS account
        /// IDs. The current AWS account can then invite these members to manage GuardDuty in
        /// their accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        CreateMembersResponse CreateMembers(CreateMembersRequest request);



        /// <summary>
        /// Creates member accounts of the current AWS account by specifying a list of AWS account
        /// IDs. The current AWS account can then invite these members to manage GuardDuty in
        /// their accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        Task<CreateMembersResponse> CreateMembersAsync(CreateMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSampleFindings


        /// <summary>
        /// Generates example findings of types specified by the list of finding types. If 'NULL'
        /// is specified for findingTypes, the API generates example findings of all supported
        /// finding types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
        /// 
        /// <returns>The response from the CreateSampleFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        CreateSampleFindingsResponse CreateSampleFindings(CreateSampleFindingsRequest request);



        /// <summary>
        /// Generates example findings of types specified by the list of finding types. If 'NULL'
        /// is specified for findingTypes, the API generates example findings of all supported
        /// finding types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSampleFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSampleFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateSampleFindings">REST API Reference for CreateSampleFindings Operation</seealso>
        Task<CreateSampleFindingsResponse> CreateSampleFindingsAsync(CreateSampleFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateThreatIntelSet


        /// <summary>
        /// Create a new ThreatIntelSet. ThreatIntelSets consist of known malicious IP addresses.
        /// GuardDuty generates findings based on ThreatIntelSets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the CreateThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateThreatIntelSet">REST API Reference for CreateThreatIntelSet Operation</seealso>
        CreateThreatIntelSetResponse CreateThreatIntelSet(CreateThreatIntelSetRequest request);



        /// <summary>
        /// Create a new ThreatIntelSet. ThreatIntelSets consist of known malicious IP addresses.
        /// GuardDuty generates findings based on ThreatIntelSets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatIntelSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/CreateThreatIntelSet">REST API Reference for CreateThreatIntelSet Operation</seealso>
        Task<CreateThreatIntelSetResponse> CreateThreatIntelSetAsync(CreateThreatIntelSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeclineInvitations


        /// <summary>
        /// Declines invitations sent to the current member account by AWS account specified by
        /// their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request);



        /// <summary>
        /// Declines invitations sent to the current member account by AWS account specified by
        /// their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        Task<DeclineInvitationsResponse> DeclineInvitationsAsync(DeclineInvitationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDetector


        /// <summary>
        /// Deletes a Amazon GuardDuty detector specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        DeleteDetectorResponse DeleteDetector(DeleteDetectorRequest request);



        /// <summary>
        /// Deletes a Amazon GuardDuty detector specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteDetector">REST API Reference for DeleteDetector Operation</seealso>
        Task<DeleteDetectorResponse> DeleteDetectorAsync(DeleteDetectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFilter


        /// <summary>
        /// Deletes the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        DeleteFilterResponse DeleteFilter(DeleteFilterRequest request);



        /// <summary>
        /// Deletes the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteFilter">REST API Reference for DeleteFilter Operation</seealso>
        Task<DeleteFilterResponse> DeleteFilterAsync(DeleteFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteInvitations


        /// <summary>
        /// Deletes invitations sent to the current member account by AWS accounts specified by
        /// their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request);



        /// <summary>
        /// Deletes invitations sent to the current member account by AWS accounts specified by
        /// their account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        Task<DeleteInvitationsResponse> DeleteInvitationsAsync(DeleteInvitationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIPSet


        /// <summary>
        /// Deletes the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        DeleteIPSetResponse DeleteIPSet(DeleteIPSetRequest request);



        /// <summary>
        /// Deletes the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteIPSet">REST API Reference for DeleteIPSet Operation</seealso>
        Task<DeleteIPSetResponse> DeleteIPSetAsync(DeleteIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMembers


        /// <summary>
        /// Deletes GuardDuty member accounts (to the current GuardDuty master account) specified
        /// by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        DeleteMembersResponse DeleteMembers(DeleteMembersRequest request);



        /// <summary>
        /// Deletes GuardDuty member accounts (to the current GuardDuty master account) specified
        /// by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        Task<DeleteMembersResponse> DeleteMembersAsync(DeleteMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteThreatIntelSet


        /// <summary>
        /// Deletes ThreatIntelSet specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the DeleteThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteThreatIntelSet">REST API Reference for DeleteThreatIntelSet Operation</seealso>
        DeleteThreatIntelSetResponse DeleteThreatIntelSet(DeleteThreatIntelSetRequest request);



        /// <summary>
        /// Deletes ThreatIntelSet specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThreatIntelSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DeleteThreatIntelSet">REST API Reference for DeleteThreatIntelSet Operation</seealso>
        Task<DeleteThreatIntelSetResponse> DeleteThreatIntelSetAsync(DeleteThreatIntelSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateFromMasterAccount


        /// <summary>
        /// Disassociates the current GuardDuty member account from its master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request);



        /// <summary>
        /// Disassociates the current GuardDuty member account from its master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        Task<DisassociateFromMasterAccountResponse> DisassociateFromMasterAccountAsync(DisassociateFromMasterAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateMembers


        /// <summary>
        /// Disassociates GuardDuty member accounts (to the current GuardDuty master account)
        /// specified by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers service method.</param>
        /// 
        /// <returns>The response from the DisassociateMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request);



        /// <summary>
        /// Disassociates GuardDuty member accounts (to the current GuardDuty master account)
        /// specified by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        Task<DisassociateMembersResponse> DisassociateMembersAsync(DisassociateMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDetector


        /// <summary>
        /// Retrieves an Amazon GuardDuty detector specified by the detectorId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetector service method.</param>
        /// 
        /// <returns>The response from the GetDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetDetector">REST API Reference for GetDetector Operation</seealso>
        GetDetectorResponse GetDetector(GetDetectorRequest request);



        /// <summary>
        /// Retrieves an Amazon GuardDuty detector specified by the detectorId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetDetector">REST API Reference for GetDetector Operation</seealso>
        Task<GetDetectorResponse> GetDetectorAsync(GetDetectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFilter


        /// <summary>
        /// Returns the details of the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFilter service method.</param>
        /// 
        /// <returns>The response from the GetFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFilter">REST API Reference for GetFilter Operation</seealso>
        GetFilterResponse GetFilter(GetFilterRequest request);



        /// <summary>
        /// Returns the details of the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFilter">REST API Reference for GetFilter Operation</seealso>
        Task<GetFilterResponse> GetFilterAsync(GetFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFindings


        /// <summary>
        /// Describes Amazon GuardDuty findings specified by finding IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindings">REST API Reference for GetFindings Operation</seealso>
        GetFindingsResponse GetFindings(GetFindingsRequest request);



        /// <summary>
        /// Describes Amazon GuardDuty findings specified by finding IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindings">REST API Reference for GetFindings Operation</seealso>
        Task<GetFindingsResponse> GetFindingsAsync(GetFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFindingsStatistics


        /// <summary>
        /// Lists Amazon GuardDuty findings' statistics for the specified detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics service method.</param>
        /// 
        /// <returns>The response from the GetFindingsStatistics service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        GetFindingsStatisticsResponse GetFindingsStatistics(GetFindingsStatisticsRequest request);



        /// <summary>
        /// Lists Amazon GuardDuty findings' statistics for the specified detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindingsStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFindingsStatistics service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetFindingsStatistics">REST API Reference for GetFindingsStatistics Operation</seealso>
        Task<GetFindingsStatisticsResponse> GetFindingsStatisticsAsync(GetFindingsStatisticsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInvitationsCount


        /// <summary>
        /// Returns the count of all GuardDuty membership invitations that were sent to the current
        /// member account except the currently accepted invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request);



        /// <summary>
        /// Returns the count of all GuardDuty membership invitations that were sent to the current
        /// member account except the currently accepted invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        Task<GetInvitationsCountResponse> GetInvitationsCountAsync(GetInvitationsCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIPSet


        /// <summary>
        /// Retrieves the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        GetIPSetResponse GetIPSet(GetIPSetRequest request);



        /// <summary>
        /// Retrieves the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetIPSet">REST API Reference for GetIPSet Operation</seealso>
        Task<GetIPSetResponse> GetIPSetAsync(GetIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMasterAccount


        /// <summary>
        /// Provides the details for the GuardDuty master account associated with the current
        /// GuardDuty member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request);



        /// <summary>
        /// Provides the details for the GuardDuty master account associated with the current
        /// GuardDuty member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        Task<GetMasterAccountResponse> GetMasterAccountAsync(GetMasterAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMembers


        /// <summary>
        /// Retrieves GuardDuty member accounts (to the current GuardDuty master account) specified
        /// by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMembers">REST API Reference for GetMembers Operation</seealso>
        GetMembersResponse GetMembers(GetMembersRequest request);



        /// <summary>
        /// Retrieves GuardDuty member accounts (to the current GuardDuty master account) specified
        /// by the account IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetMembers">REST API Reference for GetMembers Operation</seealso>
        Task<GetMembersResponse> GetMembersAsync(GetMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetThreatIntelSet


        /// <summary>
        /// Retrieves the ThreatIntelSet that is specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the GetThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetThreatIntelSet">REST API Reference for GetThreatIntelSet Operation</seealso>
        GetThreatIntelSetResponse GetThreatIntelSet(GetThreatIntelSetRequest request);



        /// <summary>
        /// Retrieves the ThreatIntelSet that is specified by the ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThreatIntelSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/GetThreatIntelSet">REST API Reference for GetThreatIntelSet Operation</seealso>
        Task<GetThreatIntelSetResponse> GetThreatIntelSetAsync(GetThreatIntelSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InviteMembers


        /// <summary>
        /// Invites other AWS accounts (created as members of the current AWS account by CreateMembers)
        /// to enable GuardDuty and allow the current AWS account to view and manage these accounts'
        /// GuardDuty findings on their behalf as the master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers service method.</param>
        /// 
        /// <returns>The response from the InviteMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        InviteMembersResponse InviteMembers(InviteMembersRequest request);



        /// <summary>
        /// Invites other AWS accounts (created as members of the current AWS account by CreateMembers)
        /// to enable GuardDuty and allow the current AWS account to view and manage these accounts'
        /// GuardDuty findings on their behalf as the master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InviteMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        Task<InviteMembersResponse> InviteMembersAsync(InviteMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDetectors


        /// <summary>
        /// Lists detectorIds of all the existing Amazon GuardDuty detector resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors service method.</param>
        /// 
        /// <returns>The response from the ListDetectors service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        ListDetectorsResponse ListDetectors(ListDetectorsRequest request);



        /// <summary>
        /// Lists detectorIds of all the existing Amazon GuardDuty detector resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDetectors service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListDetectors">REST API Reference for ListDetectors Operation</seealso>
        Task<ListDetectorsResponse> ListDetectorsAsync(ListDetectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFilters


        /// <summary>
        /// Returns a paginated list of the current filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFilters">REST API Reference for ListFilters Operation</seealso>
        ListFiltersResponse ListFilters(ListFiltersRequest request);



        /// <summary>
        /// Returns a paginated list of the current filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFilters service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFilters">REST API Reference for ListFilters Operation</seealso>
        Task<ListFiltersResponse> ListFiltersAsync(ListFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Lists Amazon GuardDuty findings for the specified detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse ListFindings(ListFindingsRequest request);



        /// <summary>
        /// Lists Amazon GuardDuty findings for the specified detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListFindings">REST API Reference for ListFindings Operation</seealso>
        Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInvitations


        /// <summary>
        /// Lists all GuardDuty membership invitations that were sent to the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        ListInvitationsResponse ListInvitations(ListInvitationsRequest request);



        /// <summary>
        /// Lists all GuardDuty membership invitations that were sent to the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        Task<ListInvitationsResponse> ListInvitationsAsync(ListInvitationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIPSets


        /// <summary>
        /// Lists the IPSets of the GuardDuty service specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        ListIPSetsResponse ListIPSets(ListIPSetsRequest request);



        /// <summary>
        /// Lists the IPSets of the GuardDuty service specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIPSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIPSets service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListIPSets">REST API Reference for ListIPSets Operation</seealso>
        Task<ListIPSetsResponse> ListIPSetsAsync(ListIPSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// Lists details about all member accounts for the current GuardDuty master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse ListMembers(ListMembersRequest request);



        /// <summary>
        /// Lists details about all member accounts for the current GuardDuty master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListMembers">REST API Reference for ListMembers Operation</seealso>
        Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for a resource. Tagging is currently supported for detectors, finding filters,
        /// IP sets, and Threat Intel sets, with a limit of 50 tags per resource. When invoked,
        /// this operation returns all assigned tags for a given resource..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists tags for a resource. Tagging is currently supported for detectors, finding filters,
        /// IP sets, and Threat Intel sets, with a limit of 50 tags per resource. When invoked,
        /// this operation returns all assigned tags for a given resource..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThreatIntelSets


        /// <summary>
        /// Lists the ThreatIntelSets of the GuardDuty service specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatIntelSets service method.</param>
        /// 
        /// <returns>The response from the ListThreatIntelSets service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListThreatIntelSets">REST API Reference for ListThreatIntelSets Operation</seealso>
        ListThreatIntelSetsResponse ListThreatIntelSets(ListThreatIntelSetsRequest request);



        /// <summary>
        /// Lists the ThreatIntelSets of the GuardDuty service specified by the detector ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatIntelSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThreatIntelSets service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/ListThreatIntelSets">REST API Reference for ListThreatIntelSets Operation</seealso>
        Task<ListThreatIntelSetsResponse> ListThreatIntelSetsAsync(ListThreatIntelSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMonitoringMembers


        /// <summary>
        /// Re-enables GuardDuty to monitor findings of the member accounts specified by the account
        /// IDs. A master GuardDuty account can run this command after disabling GuardDuty from
        /// monitoring these members' findings by running StopMonitoringMembers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMembers service method.</param>
        /// 
        /// <returns>The response from the StartMonitoringMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMonitoringMembers">REST API Reference for StartMonitoringMembers Operation</seealso>
        StartMonitoringMembersResponse StartMonitoringMembers(StartMonitoringMembersRequest request);



        /// <summary>
        /// Re-enables GuardDuty to monitor findings of the member accounts specified by the account
        /// IDs. A master GuardDuty account can run this command after disabling GuardDuty from
        /// monitoring these members' findings by running StopMonitoringMembers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitoringMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMonitoringMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StartMonitoringMembers">REST API Reference for StartMonitoringMembers Operation</seealso>
        Task<StartMonitoringMembersResponse> StartMonitoringMembersAsync(StartMonitoringMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopMonitoringMembers


        /// <summary>
        /// Disables GuardDuty from monitoring findings of the member accounts specified by the
        /// account IDs. After running this command, a master GuardDuty account can run StartMonitoringMembers
        /// to re-enable GuardDuty to monitor these members’ findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringMembers service method.</param>
        /// 
        /// <returns>The response from the StopMonitoringMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StopMonitoringMembers">REST API Reference for StopMonitoringMembers Operation</seealso>
        StopMonitoringMembersResponse StopMonitoringMembers(StopMonitoringMembersRequest request);



        /// <summary>
        /// Disables GuardDuty from monitoring findings of the member accounts specified by the
        /// account IDs. After running this command, a master GuardDuty account can run StartMonitoringMembers
        /// to re-enable GuardDuty to monitor these members’ findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMonitoringMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopMonitoringMembers service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/StopMonitoringMembers">REST API Reference for StopMonitoringMembers Operation</seealso>
        Task<StopMonitoringMembersResponse> StopMonitoringMembersAsync(StopMonitoringMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UnarchiveFindings


        /// <summary>
        /// Unarchives Amazon GuardDuty findings specified by the list of finding IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveFindings service method.</param>
        /// 
        /// <returns>The response from the UnarchiveFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UnarchiveFindings">REST API Reference for UnarchiveFindings Operation</seealso>
        UnarchiveFindingsResponse UnarchiveFindings(UnarchiveFindingsRequest request);



        /// <summary>
        /// Unarchives Amazon GuardDuty findings specified by the list of finding IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnarchiveFindings service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UnarchiveFindings">REST API Reference for UnarchiveFindings Operation</seealso>
        Task<UnarchiveFindingsResponse> UnarchiveFindingsAsync(UnarchiveFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDetector


        /// <summary>
        /// Updates an Amazon GuardDuty detector specified by the detectorId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetector service method.</param>
        /// 
        /// <returns>The response from the UpdateDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateDetector">REST API Reference for UpdateDetector Operation</seealso>
        UpdateDetectorResponse UpdateDetector(UpdateDetectorRequest request);



        /// <summary>
        /// Updates an Amazon GuardDuty detector specified by the detectorId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDetector service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateDetector">REST API Reference for UpdateDetector Operation</seealso>
        Task<UpdateDetectorResponse> UpdateDetectorAsync(UpdateDetectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFilter


        /// <summary>
        /// Updates the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        UpdateFilterResponse UpdateFilter(UpdateFilterRequest request);



        /// <summary>
        /// Updates the filter specified by the filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFilter service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFilter">REST API Reference for UpdateFilter Operation</seealso>
        Task<UpdateFilterResponse> UpdateFilterAsync(UpdateFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFindingsFeedback


        /// <summary>
        /// Marks specified Amazon GuardDuty findings as useful or not useful.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFeedback service method.</param>
        /// 
        /// <returns>The response from the UpdateFindingsFeedback service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFindingsFeedback">REST API Reference for UpdateFindingsFeedback Operation</seealso>
        UpdateFindingsFeedbackResponse UpdateFindingsFeedback(UpdateFindingsFeedbackRequest request);



        /// <summary>
        /// Marks specified Amazon GuardDuty findings as useful or not useful.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindingsFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFindingsFeedback service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateFindingsFeedback">REST API Reference for UpdateFindingsFeedback Operation</seealso>
        Task<UpdateFindingsFeedbackResponse> UpdateFindingsFeedbackAsync(UpdateFindingsFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIPSet


        /// <summary>
        /// Updates the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        UpdateIPSetResponse UpdateIPSet(UpdateIPSetRequest request);



        /// <summary>
        /// Updates the IPSet specified by the IPSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIPSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIPSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateIPSet">REST API Reference for UpdateIPSet Operation</seealso>
        Task<UpdateIPSetResponse> UpdateIPSetAsync(UpdateIPSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateThreatIntelSet


        /// <summary>
        /// Updates the ThreatIntelSet specified by ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatIntelSet service method.</param>
        /// 
        /// <returns>The response from the UpdateThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateThreatIntelSet">REST API Reference for UpdateThreatIntelSet Operation</seealso>
        UpdateThreatIntelSetResponse UpdateThreatIntelSet(UpdateThreatIntelSetRequest request);



        /// <summary>
        /// Updates the ThreatIntelSet specified by ThreatIntelSet ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatIntelSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThreatIntelSet service method, as returned by GuardDuty.</returns>
        /// <exception cref="Amazon.GuardDuty.Model.BadRequestException">
        /// Bad request exception object.
        /// </exception>
        /// <exception cref="Amazon.GuardDuty.Model.InternalServerErrorException">
        /// Internal server error exception object.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/guardduty-2017-11-28/UpdateThreatIntelSet">REST API Reference for UpdateThreatIntelSet Operation</seealso>
        Task<UpdateThreatIntelSetResponse> UpdateThreatIntelSetAsync(UpdateThreatIntelSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}