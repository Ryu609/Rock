//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System.ServiceModel;

namespace Rock.REST.Core
{
	/// <summary>
	/// Represents a REST WCF service for MetricValues
	/// </summary>
	[ServiceContract]
    public partial interface IMetricValueService
    {
		/// <summary>
		/// Gets a MetricValue object
		/// </summary>
		[OperationContract]
        Rock.Core.DTO.MetricValue Get( string id );

		/// <summary>
		/// Gets a MetricValue object
		/// </summary>
		[OperationContract]
        Rock.Core.DTO.MetricValue ApiGet( string id, string apiKey );

		/// <summary>
		/// Updates a MetricValue object
		/// </summary>
        [OperationContract]
        void UpdateMetricValue( string id, Rock.Core.DTO.MetricValue metricValue );

		/// <summary>
		/// Updates a MetricValue object
		/// </summary>
        [OperationContract]
        void ApiUpdateMetricValue( string id, string apiKey, Rock.Core.DTO.MetricValue metricValue );

		/// <summary>
		/// Creates a new MetricValue object
		/// </summary>
        [OperationContract]
        void CreateMetricValue( Rock.Core.DTO.MetricValue metricValue );

		/// <summary>
		/// Creates a new MetricValue object
		/// </summary>
        [OperationContract]
        void ApiCreateMetricValue( string apiKey, Rock.Core.DTO.MetricValue metricValue );

		/// <summary>
		/// Deletes a MetricValue object
		/// </summary>
        [OperationContract]
        void DeleteMetricValue( string id );

		/// <summary>
		/// Deletes a MetricValue object
		/// </summary>
        [OperationContract]
        void ApiDeleteMetricValue( string id, string apiKey );
    }
}
