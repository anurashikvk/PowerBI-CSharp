// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Power BI dashboard returned by WorkspaceInfo APIs. The API returns a
    /// subset of the following list of dashboard properties. The subset
    /// depends on the API called, caller permissions, and the availability of
    /// data in the Power BI database.
    /// </summary>
    public partial class WorkspaceInfoDashboard
    {
        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoDashboard class.
        /// </summary>
        public WorkspaceInfoDashboard()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkspaceInfoDashboard class.
        /// </summary>
        /// <param name="id">The dashboard ID</param>
        /// <param name="displayName">The display name of the dashboard</param>
        /// <param name="isReadOnly">Whether the dashboard is read-only</param>
        /// <param name="appId">The app ID, returned only if the dashboard
        /// belongs to an app</param>
        /// <param name="dataClassification">The data classification tag of the
        /// artifact</param>
        /// <param name="sensitivityLabel">The sensitivity label</param>
        /// <param name="tiles">The tiles that belong to the dashboard</param>
        /// <param name="users">(Empty value) The dashboard user access
        /// details. This property will be removed from the payload response in
        /// an upcoming release. You can retrieve user information on a Power
        /// BI item (such as a report or a dashboard) by using the [Get
        /// Dashboard Users as
        /// Admin](/rest/api/power-bi/admin/dashboards-get-dashboard-users-as-admin)
        /// API, or the
        /// [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API with the `getArtifactUsers` parameter.</param>
        public WorkspaceInfoDashboard(System.Guid id, string displayName = default(string), bool? isReadOnly = default(bool?), string appId = default(string), string dataClassification = default(string), SensitivityLabel sensitivityLabel = default(SensitivityLabel), IList<WorkspaceInfoTile> tiles = default(IList<WorkspaceInfoTile>), IList<DashboardUser> users = default(IList<DashboardUser>))
        {
            Id = id;
            DisplayName = displayName;
            IsReadOnly = isReadOnly;
            AppId = appId;
            DataClassification = dataClassification;
            SensitivityLabel = sensitivityLabel;
            Tiles = tiles;
            Users = users;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the dashboard ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the display name of the dashboard
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets whether the dashboard is read-only
        /// </summary>
        [JsonProperty(PropertyName = "isReadOnly")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the app ID, returned only if the dashboard belongs to
        /// an app
        /// </summary>
        [JsonProperty(PropertyName = "appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets the data classification tag of the artifact
        /// </summary>
        [JsonProperty(PropertyName = "dataClassification")]
        public string DataClassification { get; set; }

        /// <summary>
        /// Gets or sets the sensitivity label
        /// </summary>
        [JsonProperty(PropertyName = "sensitivityLabel")]
        public SensitivityLabel SensitivityLabel { get; set; }

        /// <summary>
        /// Gets or sets the tiles that belong to the dashboard
        /// </summary>
        [JsonProperty(PropertyName = "tiles")]
        public IList<WorkspaceInfoTile> Tiles { get; set; }

        /// <summary>
        /// Gets or sets (Empty value) The dashboard user access details. This
        /// property will be removed from the payload response in an upcoming
        /// release. You can retrieve user information on a Power BI item (such
        /// as a report or a dashboard) by using the [Get Dashboard Users as
        /// Admin](/rest/api/power-bi/admin/dashboards-get-dashboard-users-as-admin)
        /// API, or the
        /// [PostWorkspaceInfo](/rest/api/power-bi/admin/workspace-info-post-workspace-info)
        /// API with the `getArtifactUsers` parameter.
        /// </summary>
        [JsonProperty(PropertyName = "users")]
        public IList<DashboardUser> Users { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SensitivityLabel != null)
            {
                SensitivityLabel.Validate();
            }
            if (Tiles != null)
            {
                foreach (var element in Tiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Users != null)
            {
                foreach (var element1 in Users)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
