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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ForecastService.Model;

namespace Amazon.ForecastService
{
    /// <summary>
    /// Interface for accessing ForecastService
    ///
    /// Provides APIs for creating and managing Amazon Forecast resources.
    /// </summary>
    public partial interface IAmazonForecastService : IAmazonService, IDisposable
    {

        
        #region  CreateDataset


        /// <summary>
        /// Creates an Amazon Forecast dataset. The information about the dataset that you provide
        /// helps Forecast understand how to consume the data for model training. This includes
        /// the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <i> <code>DataFrequency</code> </i> - How frequently your historical time-series
        /// data is collected. Amazon Forecast uses this information when training the model and
        /// generating a forecast.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>Domain</code> </i> and <i> <code>DatasetType</code> </i> - Each dataset
        /// has an associated dataset domain and a type within the domain. Amazon Forecast provides
        /// a list of predefined domains and types within each domain. For each unique dataset
        /// domain and type within the domain, Amazon Forecast requires your data to include a
        /// minimum set of predefined fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>Schema</code> </i> - A schema specifies the fields of the dataset, including
        /// the field name and data type.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After creating a dataset, you import your training data into the dataset and add the
        /// dataset to a dataset group. You then use the dataset group to create a predictor.
        /// For more information, see <a>howitworks-datasets-groups</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your datasets, use the <a>ListDatasets</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of a dataset must be <code>ACTIVE</code> before you can import
        /// training data. Use the <a>DescribeDataset</a> operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse CreateDataset(CreateDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatasetGroup


        /// <summary>
        /// Creates an Amazon Forecast dataset group, which holds a collection of related datasets.
        /// You can add datasets to the dataset group when you create the dataset group, or you
        /// can add datasets later with the <a>UpdateDatasetGroup</a> operation.
        /// 
        ///  
        /// <para>
        /// After creating a dataset group and adding datasets, you use the dataset group when
        /// you create a predictor. For more information, see <a>howitworks-datasets-groups</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your datasets groups, use the <a>ListDatasetGroups</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of a dataset group must be <code>ACTIVE</code> before you
        /// can create a predictor using the dataset group. Use the <a>DescribeDatasetGroup</a>
        /// operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        CreateDatasetGroupResponse CreateDatasetGroup(CreateDatasetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        IAsyncResult BeginCreateDatasetGroup(CreateDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetGroup.</param>
        /// 
        /// <returns>Returns a  CreateDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetGroup">REST API Reference for CreateDatasetGroup Operation</seealso>
        CreateDatasetGroupResponse EndCreateDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatasetImportJob


        /// <summary>
        /// Imports your training data to an Amazon Forecast dataset. You provide the location
        /// of your training data in an Amazon Simple Storage Service (Amazon S3) bucket and the
        /// Amazon Resource Name (ARN) of the dataset that you want to import the data to.
        /// 
        ///  
        /// <para>
        /// You must specify a <a>DataSource</a> object that includes an AWS Identity and Access
        /// Management (IAM) role that Amazon Forecast can assume to access the data. For more
        /// information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  
        /// <para>
        /// Two properties of the training data are optionally specified:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The delimiter that separates the data fields.
        /// </para>
        ///  
        /// <para>
        /// The default delimiter is a comma (,), which is the only supported delimiter in this
        /// release.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The format of timestamps.
        /// </para>
        ///  
        /// <para>
        /// If the format is not specified, Amazon Forecast expects the format to be "yyyy-MM-dd
        /// HH:mm:ss".
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When Amazon Forecast uploads your training data, it verifies that the data was collected
        /// at the <code>DataFrequency</code> specified when the target dataset was created. For
        /// more information, see <a>CreateDataset</a> and <a>howitworks-datasets-groups</a>.
        /// Amazon Forecast also verifies the delimiter and timestamp format.
        /// </para>
        ///  
        /// <para>
        /// You can use the <a>ListDatasetImportJobs</a> operation to get a list of all your dataset
        /// import jobs, filtered by specified criteria.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your dataset import jobs, filtered by the specified criteria,
        /// use the <a>ListDatasetGroups</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetImportJob service method.</param>
        /// 
        /// <returns>The response from the CreateDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        CreateDatasetImportJobResponse CreateDatasetImportJob(CreateDatasetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatasetImportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        IAsyncResult BeginCreateDatasetImportJob(CreateDatasetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  CreateDatasetImportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateDatasetImportJob">REST API Reference for CreateDatasetImportJob Operation</seealso>
        CreateDatasetImportJobResponse EndCreateDatasetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateForecast


        /// <summary>
        /// Creates a forecast for each item in the <code>TARGET_TIME_SERIES</code> dataset that
        /// was used to train the predictor. This is known as inference. To retrieve the forecast
        /// for a single item at low latency, use the operation. To export the complete forecast
        /// into your Amazon Simple Storage Service (Amazon S3), use the <a>CreateForecastExportJob</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// The range of the forecast is determined by the <code>ForecastHorizon</code>, specified
        /// in the <a>CreatePredictor</a> request, multiplied by the <code>DataFrequency</code>,
        /// specified in the <a>CreateDataset</a> request. When you query a forecast, you can
        /// request a specific date range within the complete forecast.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your forecasts, use the <a>ListForecasts</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The forecasts generated by Amazon Forecast are in the same timezone as the dataset
        /// that was used to create the predictor.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a>howitworks-forecast</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the forecast must be <code>ACTIVE</code> before you can
        /// query or export the forecast. Use the <a>DescribeForecast</a> operation to get the
        /// status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForecast service method.</param>
        /// 
        /// <returns>The response from the CreateForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecast">REST API Reference for CreateForecast Operation</seealso>
        CreateForecastResponse CreateForecast(CreateForecastRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecast">REST API Reference for CreateForecast Operation</seealso>
        IAsyncResult BeginCreateForecast(CreateForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateForecast.</param>
        /// 
        /// <returns>Returns a  CreateForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecast">REST API Reference for CreateForecast Operation</seealso>
        CreateForecastResponse EndCreateForecast(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateForecastExportJob


        /// <summary>
        /// Exports a forecast created by the <a>CreateForecast</a> operation to your Amazon Simple
        /// Storage Service (Amazon S3) bucket.
        /// 
        ///  
        /// <para>
        /// You must specify a <a>DataDestination</a> object that includes an AWS Identity and
        /// Access Management (IAM) role that Amazon Forecast can assume to access the Amazon
        /// S3 bucket. For more information, see <a>aws-forecast-iam-roles</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>howitworks-forecast</a>.
        /// </para>
        ///  
        /// <para>
        /// To get a list of all your forecast export jobs, use the <a>ListForecastExportJobs</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the forecast export job must be <code>ACTIVE</code> before
        /// you can access the forecast in your Amazon S3 bucket. Use the <a>DescribeForecastExportJob</a>
        /// operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateForecastExportJob service method.</param>
        /// 
        /// <returns>The response from the CreateForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecastExportJob">REST API Reference for CreateForecastExportJob Operation</seealso>
        CreateForecastExportJobResponse CreateForecastExportJob(CreateForecastExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateForecastExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateForecastExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecastExportJob">REST API Reference for CreateForecastExportJob Operation</seealso>
        IAsyncResult BeginCreateForecastExportJob(CreateForecastExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateForecastExportJob.</param>
        /// 
        /// <returns>Returns a  CreateForecastExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreateForecastExportJob">REST API Reference for CreateForecastExportJob Operation</seealso>
        CreateForecastExportJobResponse EndCreateForecastExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePredictor


        /// <summary>
        /// Creates an Amazon Forecast predictor.
        /// 
        ///  
        /// <para>
        /// In the request, you provide a dataset group and either specify an algorithm or let
        /// Amazon Forecast choose the algorithm for you using AutoML. If you specify an algorithm,
        /// you also can override algorithm-specific hyperparameters.
        /// </para>
        ///  
        /// <para>
        /// Amazon Forecast uses the chosen algorithm to train a model using the latest version
        /// of the datasets in the specified dataset group. The result is called a predictor.
        /// You then generate a forecast using the <a>CreateForecast</a> operation.
        /// </para>
        ///  
        /// <para>
        /// After training a model, the <code>CreatePredictor</code> operation also evaluates
        /// it. To see the evaluation metrics, use the <a>GetAccuracyMetrics</a> operation. Always
        /// review the evaluation metrics before deciding to use the predictor to generate a forecast.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can specify a featurization configuration to fill and aggragate the
        /// data fields in the <code>TARGET_TIME_SERIES</code> dataset to improve model training.
        /// For more information, see <a>FeaturizationConfig</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>AutoML</b> 
        /// </para>
        ///  
        /// <para>
        /// If you set <code>PerformAutoML</code> to <code>true</code>, Amazon Forecast evaluates
        /// each algorithm and chooses the one that minimizes the <code>objective function</code>.
        /// The <code>objective function</code> is defined as the mean of the weighted p10, p50,
        /// and p90 quantile losses. For more information, see <a>EvaluationResult</a>.
        /// </para>
        ///  
        /// <para>
        /// When AutoML is enabled, the following properties are disallowed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AlgorithmArn</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HPOConfig</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PerformHPO</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TrainingParameters</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get a list of all your predictors, use the <a>ListPredictors</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the predictor must be <code>ACTIVE</code>, signifying that
        /// training has completed, before you can use the predictor to create a forecast. Use
        /// the <a>DescribePredictor</a> operation to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictor service method.</param>
        /// 
        /// <returns>The response from the CreatePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.LimitExceededException">
        /// The limit on the number of requests per second has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceAlreadyExistsException">
        /// There is already a resource with that Amazon Resource Name (ARN). Try again with a
        /// different ARN.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictor">REST API Reference for CreatePredictor Operation</seealso>
        CreatePredictorResponse CreatePredictor(CreatePredictorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictor">REST API Reference for CreatePredictor Operation</seealso>
        IAsyncResult BeginCreatePredictor(CreatePredictorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePredictor.</param>
        /// 
        /// <returns>Returns a  CreatePredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/CreatePredictor">REST API Reference for CreatePredictor Operation</seealso>
        CreatePredictorResponse EndCreatePredictor(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataset


        /// <summary>
        /// Deletes an Amazon Forecast dataset created using the <a>CreateDataset</a> operation.
        /// To be deleted, the dataset must have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// Use the <a>DescribeDataset</a> operation to get the status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset service method.</param>
        /// 
        /// <returns>The response from the DeleteDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse DeleteDataset(DeleteDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        IAsyncResult BeginDeleteDataset(DeleteDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataset.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDataset">REST API Reference for DeleteDataset Operation</seealso>
        DeleteDatasetResponse EndDeleteDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatasetGroup


        /// <summary>
        /// Deletes a dataset group created using the <a>CreateDatasetGroup</a> operation. To
        /// be deleted, the dataset group must have a status of <code>ACTIVE</code>, <code>CREATE_FAILED</code>,
        /// or <code>UPDATE_FAILED</code>. Use the <a>DescribeDatasetGroup</a> operation to get
        /// the status.
        /// 
        ///  
        /// <para>
        /// The operation deletes only the dataset group, not the datasets in the group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        DeleteDatasetGroupResponse DeleteDatasetGroup(DeleteDatasetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        IAsyncResult BeginDeleteDatasetGroup(DeleteDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatasetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetGroup">REST API Reference for DeleteDatasetGroup Operation</seealso>
        DeleteDatasetGroupResponse EndDeleteDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatasetImportJob


        /// <summary>
        /// Deletes a dataset import job created using the <a>CreateDatasetImportJob</a> operation.
        /// To be deleted, the import job must have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// Use the <a>DescribeDatasetImportJob</a> operation to get the status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetImportJob service method.</param>
        /// 
        /// <returns>The response from the DeleteDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetImportJob">REST API Reference for DeleteDatasetImportJob Operation</seealso>
        DeleteDatasetImportJobResponse DeleteDatasetImportJob(DeleteDatasetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatasetImportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetImportJob">REST API Reference for DeleteDatasetImportJob Operation</seealso>
        IAsyncResult BeginDeleteDatasetImportJob(DeleteDatasetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  DeleteDatasetImportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteDatasetImportJob">REST API Reference for DeleteDatasetImportJob Operation</seealso>
        DeleteDatasetImportJobResponse EndDeleteDatasetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteForecast


        /// <summary>
        /// Deletes a forecast created using the <a>CreateForecast</a> operation. To be deleted,
        /// the forecast must have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// Use the <a>DescribeForecast</a> operation to get the status.
        /// 
        ///  
        /// <para>
        /// You can't delete a forecast while it is being exported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecast service method.</param>
        /// 
        /// <returns>The response from the DeleteForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecast">REST API Reference for DeleteForecast Operation</seealso>
        DeleteForecastResponse DeleteForecast(DeleteForecastRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecast">REST API Reference for DeleteForecast Operation</seealso>
        IAsyncResult BeginDeleteForecast(DeleteForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteForecast.</param>
        /// 
        /// <returns>Returns a  DeleteForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecast">REST API Reference for DeleteForecast Operation</seealso>
        DeleteForecastResponse EndDeleteForecast(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteForecastExportJob


        /// <summary>
        /// Deletes a forecast export job created using the <a>CreateForecastExportJob</a> operation.
        /// To be deleted, the export job must have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// Use the <a>DescribeForecastExportJob</a> operation to get the status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecastExportJob service method.</param>
        /// 
        /// <returns>The response from the DeleteForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecastExportJob">REST API Reference for DeleteForecastExportJob Operation</seealso>
        DeleteForecastExportJobResponse DeleteForecastExportJob(DeleteForecastExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteForecastExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteForecastExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecastExportJob">REST API Reference for DeleteForecastExportJob Operation</seealso>
        IAsyncResult BeginDeleteForecastExportJob(DeleteForecastExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteForecastExportJob.</param>
        /// 
        /// <returns>Returns a  DeleteForecastExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeleteForecastExportJob">REST API Reference for DeleteForecastExportJob Operation</seealso>
        DeleteForecastExportJobResponse EndDeleteForecastExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePredictor


        /// <summary>
        /// Deletes a predictor created using the <a>CreatePredictor</a> operation. To be deleted,
        /// the predictor must have a status of <code>ACTIVE</code> or <code>CREATE_FAILED</code>.
        /// Use the <a>DescribePredictor</a> operation to get the status.
        /// 
        ///  
        /// <para>
        /// Any forecasts generated by the predictor will no longer be available.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictor service method.</param>
        /// 
        /// <returns>The response from the DeletePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictor">REST API Reference for DeletePredictor Operation</seealso>
        DeletePredictorResponse DeletePredictor(DeletePredictorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictor">REST API Reference for DeletePredictor Operation</seealso>
        IAsyncResult BeginDeletePredictor(DeletePredictorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePredictor.</param>
        /// 
        /// <returns>Returns a  DeletePredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DeletePredictor">REST API Reference for DeletePredictor Operation</seealso>
        DeletePredictorResponse EndDeletePredictor(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Describes an Amazon Forecast dataset created using the <a>CreateDataset</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateDataset</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDatasetGroup


        /// <summary>
        /// Describes a dataset group created using the <a>CreateDatasetGroup</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateDatasetGroup</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetArns</code> - The datasets belonging to the group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        DescribeDatasetGroupResponse DescribeDatasetGroup(DescribeDatasetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        IAsyncResult BeginDescribeDatasetGroup(DescribeDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetGroup.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetGroup">REST API Reference for DescribeDatasetGroup Operation</seealso>
        DescribeDatasetGroupResponse EndDescribeDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDatasetImportJob


        /// <summary>
        /// Describes a dataset import job created using the <a>CreateDatasetImportJob</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateDatasetImportJob</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DataSize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FieldStatistics</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDatasetImportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        DescribeDatasetImportJobResponse DescribeDatasetImportJob(DescribeDatasetImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatasetImportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatasetImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        IAsyncResult BeginDescribeDatasetImportJob(DescribeDatasetImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatasetImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatasetImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetImportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeDatasetImportJob">REST API Reference for DescribeDatasetImportJob Operation</seealso>
        DescribeDatasetImportJobResponse EndDescribeDatasetImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeForecast


        /// <summary>
        /// Describes a forecast created using the <a>CreateForecast</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateForecast</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetGroupArn</code> - The dataset group that provided the training data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecast service method.</param>
        /// 
        /// <returns>The response from the DescribeForecast service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecast">REST API Reference for DescribeForecast Operation</seealso>
        DescribeForecastResponse DescribeForecast(DescribeForecastRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeForecast operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecast operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeForecast
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecast">REST API Reference for DescribeForecast Operation</seealso>
        IAsyncResult BeginDescribeForecast(DescribeForecastRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeForecast operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeForecast.</param>
        /// 
        /// <returns>Returns a  DescribeForecastResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecast">REST API Reference for DescribeForecast Operation</seealso>
        DescribeForecastResponse EndDescribeForecast(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeForecastExportJob


        /// <summary>
        /// Describes a forecast export job created using the <a>CreateForecastExportJob</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreateForecastExportJob</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecastExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeForecastExportJob service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecastExportJob">REST API Reference for DescribeForecastExportJob Operation</seealso>
        DescribeForecastExportJobResponse DescribeForecastExportJob(DescribeForecastExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeForecastExportJob operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeForecastExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecastExportJob">REST API Reference for DescribeForecastExportJob Operation</seealso>
        IAsyncResult BeginDescribeForecastExportJob(DescribeForecastExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeForecastExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeForecastExportJob.</param>
        /// 
        /// <returns>Returns a  DescribeForecastExportJobResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribeForecastExportJob">REST API Reference for DescribeForecastExportJob Operation</seealso>
        DescribeForecastExportJobResponse EndDescribeForecastExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePredictor


        /// <summary>
        /// Describes a predictor created using the <a>CreatePredictor</a> operation.
        /// 
        ///  
        /// <para>
        /// In addition to listing the properties provided by the user in the <code>CreatePredictor</code>
        /// request, this operation includes the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DatasetImportJobArns</code> - The dataset import jobs used to import training
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AutoMLAlgorithmArns</code> - If AutoML is performed, the algorithms evaluated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CreationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LastModificationTime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Status</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Message</code> - If an error occurred, information about the error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictor service method.</param>
        /// 
        /// <returns>The response from the DescribePredictor service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictor">REST API Reference for DescribePredictor Operation</seealso>
        DescribePredictorResponse DescribePredictor(DescribePredictorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePredictor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePredictor operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePredictor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictor">REST API Reference for DescribePredictor Operation</seealso>
        IAsyncResult BeginDescribePredictor(DescribePredictorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePredictor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePredictor.</param>
        /// 
        /// <returns>Returns a  DescribePredictorResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/DescribePredictor">REST API Reference for DescribePredictor Operation</seealso>
        DescribePredictorResponse EndDescribePredictor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccuracyMetrics


        /// <summary>
        /// Provides metrics on the accuracy of the models that were trained by the <a>CreatePredictor</a>
        /// operation. Use metrics to see how well the model performed and to decide whether to
        /// use the predictor to generate a forecast.
        /// 
        ///  
        /// <para>
        /// Metrics are generated for each backtest window evaluated. For more information, see
        /// <a>EvaluationParameters</a>.
        /// </para>
        ///  
        /// <para>
        /// The parameters of the <code>filling</code> method determine which items contribute
        /// to the metrics. If <code>zero</code> is specified, all items contribute. If <code>nan</code>
        /// is specified, only those items that have complete data in the range being evaluated
        /// contribute. For more information, see <a>FeaturizationMethod</a>.
        /// </para>
        ///  
        /// <para>
        /// For an example of how to train a model and review metrics, see <a>getting-started</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccuracyMetrics service method.</param>
        /// 
        /// <returns>The response from the GetAccuracyMetrics service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/GetAccuracyMetrics">REST API Reference for GetAccuracyMetrics Operation</seealso>
        GetAccuracyMetricsResponse GetAccuracyMetrics(GetAccuracyMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccuracyMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccuracyMetrics operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccuracyMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/GetAccuracyMetrics">REST API Reference for GetAccuracyMetrics Operation</seealso>
        IAsyncResult BeginGetAccuracyMetrics(GetAccuracyMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccuracyMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccuracyMetrics.</param>
        /// 
        /// <returns>Returns a  GetAccuracyMetricsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/GetAccuracyMetrics">REST API Reference for GetAccuracyMetrics Operation</seealso>
        GetAccuracyMetricsResponse EndGetAccuracyMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasetGroups


        /// <summary>
        /// Returns a list of dataset groups created using the <a>CreateDatasetGroup</a> operation.
        /// For each dataset group, a summary of its properties, including its Amazon Resource
        /// Name (ARN), is returned. You can retrieve the complete set of properties by using
        /// the ARN with the <a>DescribeDatasetGroup</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups service method.</param>
        /// 
        /// <returns>The response from the ListDatasetGroups service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        ListDatasetGroupsResponse ListDatasetGroups(ListDatasetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetGroups operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        IAsyncResult BeginListDatasetGroups(ListDatasetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetGroups.</param>
        /// 
        /// <returns>Returns a  ListDatasetGroupsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetGroups">REST API Reference for ListDatasetGroups Operation</seealso>
        ListDatasetGroupsResponse EndListDatasetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasetImportJobs


        /// <summary>
        /// Returns a list of dataset import jobs created using the <a>CreateDatasetImportJob</a>
        /// operation. For each import job, a summary of its properties, including its Amazon
        /// Resource Name (ARN), is returned. You can retrieve the complete set of properties
        /// by using the ARN with the <a>DescribeDatasetImportJob</a> operation. You can filter
        /// the list by providing an array of <a>Filter</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetImportJobs service method.</param>
        /// 
        /// <returns>The response from the ListDatasetImportJobs service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        ListDatasetImportJobsResponse ListDatasetImportJobs(ListDatasetImportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasetImportJobs operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasetImportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        IAsyncResult BeginListDatasetImportJobs(ListDatasetImportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasetImportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasetImportJobs.</param>
        /// 
        /// <returns>Returns a  ListDatasetImportJobsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasetImportJobs">REST API Reference for ListDatasetImportJobs Operation</seealso>
        ListDatasetImportJobsResponse EndListDatasetImportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// Returns a list of datasets created using the <a>CreateDataset</a> operation. For each
        /// dataset, a summary of its properties, including its Amazon Resource Name (ARN), is
        /// returned. You can retrieve the complete set of properties by using the ARN with the
        /// <a>DescribeDataset</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse ListDatasets(ListDatasetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListForecastExportJobs


        /// <summary>
        /// Returns a list of forecast export jobs created using the <a>CreateForecastExportJob</a>
        /// operation. For each forecast export job, a summary of its properties, including its
        /// Amazon Resource Name (ARN), is returned. You can retrieve the complete set of properties
        /// by using the ARN with the <a>DescribeForecastExportJob</a> operation. The list can
        /// be filtered using an array of <a>Filter</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForecastExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListForecastExportJobs service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecastExportJobs">REST API Reference for ListForecastExportJobs Operation</seealso>
        ListForecastExportJobsResponse ListForecastExportJobs(ListForecastExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListForecastExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListForecastExportJobs operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListForecastExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecastExportJobs">REST API Reference for ListForecastExportJobs Operation</seealso>
        IAsyncResult BeginListForecastExportJobs(ListForecastExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListForecastExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListForecastExportJobs.</param>
        /// 
        /// <returns>Returns a  ListForecastExportJobsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecastExportJobs">REST API Reference for ListForecastExportJobs Operation</seealso>
        ListForecastExportJobsResponse EndListForecastExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListForecasts


        /// <summary>
        /// Returns a list of forecasts created using the <a>CreateForecast</a> operation. For
        /// each forecast, a summary of its properties, including its Amazon Resource Name (ARN),
        /// is returned. You can retrieve the complete set of properties by using the ARN with
        /// the <a>DescribeForecast</a> operation. The list can be filtered using an array of
        /// <a>Filter</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListForecasts service method.</param>
        /// 
        /// <returns>The response from the ListForecasts service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecasts">REST API Reference for ListForecasts Operation</seealso>
        ListForecastsResponse ListForecasts(ListForecastsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListForecasts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListForecasts operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListForecasts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecasts">REST API Reference for ListForecasts Operation</seealso>
        IAsyncResult BeginListForecasts(ListForecastsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListForecasts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListForecasts.</param>
        /// 
        /// <returns>Returns a  ListForecastsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListForecasts">REST API Reference for ListForecasts Operation</seealso>
        ListForecastsResponse EndListForecasts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPredictors


        /// <summary>
        /// Returns a list of predictors created using the <a>CreatePredictor</a> operation. For
        /// each predictor, a summary of its properties, including its Amazon Resource Name (ARN),
        /// is returned. You can retrieve the complete set of properties by using the ARN with
        /// the <a>DescribePredictor</a> operation. The list can be filtered using an array of
        /// <a>Filter</a> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPredictors service method.</param>
        /// 
        /// <returns>The response from the ListPredictors service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.InvalidNextTokenException">
        /// The token is not valid. Tokens expire after 24 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictors">REST API Reference for ListPredictors Operation</seealso>
        ListPredictorsResponse ListPredictors(ListPredictorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPredictors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPredictors operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPredictors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictors">REST API Reference for ListPredictors Operation</seealso>
        IAsyncResult BeginListPredictors(ListPredictorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPredictors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPredictors.</param>
        /// 
        /// <returns>Returns a  ListPredictorsResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/ListPredictors">REST API Reference for ListPredictors Operation</seealso>
        ListPredictorsResponse EndListPredictors(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDatasetGroup


        /// <summary>
        /// Replaces any existing datasets in the dataset group with the specified datasets.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>Status</code> of the dataset group must be <code>ACTIVE</code> before creating
        /// a predictor using the dataset group. Use the <a>DescribeDatasetGroup</a> operation
        /// to get the status.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateDatasetGroup service method, as returned by ForecastService.</returns>
        /// <exception cref="Amazon.ForecastService.Model.InvalidInputException">
        /// We can't process the request because it includes an invalid value or a value that
        /// exceeds the valid range.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ForecastService.Model.ResourceNotFoundException">
        /// We can't find a resource with that Amazon Resource Name (ARN). Check the ARN and try
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UpdateDatasetGroup">REST API Reference for UpdateDatasetGroup Operation</seealso>
        UpdateDatasetGroupResponse UpdateDatasetGroup(UpdateDatasetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatasetGroup operation on AmazonForecastServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatasetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UpdateDatasetGroup">REST API Reference for UpdateDatasetGroup Operation</seealso>
        IAsyncResult BeginUpdateDatasetGroup(UpdateDatasetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatasetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatasetGroup.</param>
        /// 
        /// <returns>Returns a  UpdateDatasetGroupResult from ForecastService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/forecast-2018-06-26/UpdateDatasetGroup">REST API Reference for UpdateDatasetGroup Operation</seealso>
        UpdateDatasetGroupResponse EndUpdateDatasetGroup(IAsyncResult asyncResult);

        #endregion
        
    }
}