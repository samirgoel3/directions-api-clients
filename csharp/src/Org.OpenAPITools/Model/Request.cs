/* 
 * GraphHopper Directions API
 *
 * You use the GraphHopper Directions API to add route planning, navigation and route optimization to your software. E.g. the Routing API has turn instructions and elevation data and the Route Optimization API solves your logistic problems and supports various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Request
    /// </summary>
    [DataContract]
    public partial class Request :  IEquatable<Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        /// <param name="vehicles">An array of vehicles that can be employed.</param>
        /// <param name="vehicleTypes">An array of vehicle types.</param>
        /// <param name="services">An array of services.</param>
        /// <param name="shipments">An array of shipments.</param>
        /// <param name="relations">An array of relations.</param>
        /// <param name="algorithm">algorithm.</param>
        /// <param name="objectives">An array of objectives.</param>
        /// <param name="costMatrices">An array of cost matrices.</param>
        /// <param name="configuration">configuration.</param>
        public Request(List<Vehicle> vehicles = default(List<Vehicle>), List<VehicleType> vehicleTypes = default(List<VehicleType>), List<Service> services = default(List<Service>), List<Shipment> shipments = default(List<Shipment>), List<Relation> relations = default(List<Relation>), Algorithm algorithm = default(Algorithm), List<Objective> objectives = default(List<Objective>), List<CostMatrix> costMatrices = default(List<CostMatrix>), Configuration configuration = default(Configuration))
        {
            this.Vehicles = vehicles;
            this.VehicleTypes = vehicleTypes;
            this.Services = services;
            this.Shipments = shipments;
            this.Relations = relations;
            this.Algorithm = algorithm;
            this.Objectives = objectives;
            this.CostMatrices = costMatrices;
            this.Configuration = configuration;
        }
        
        /// <summary>
        /// An array of vehicles that can be employed
        /// </summary>
        /// <value>An array of vehicles that can be employed</value>
        [DataMember(Name="vehicles", EmitDefaultValue=false)]
        public List<Vehicle> Vehicles { get; set; }

        /// <summary>
        /// An array of vehicle types
        /// </summary>
        /// <value>An array of vehicle types</value>
        [DataMember(Name="vehicle_types", EmitDefaultValue=false)]
        public List<VehicleType> VehicleTypes { get; set; }

        /// <summary>
        /// An array of services
        /// </summary>
        /// <value>An array of services</value>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<Service> Services { get; set; }

        /// <summary>
        /// An array of shipments
        /// </summary>
        /// <value>An array of shipments</value>
        [DataMember(Name="shipments", EmitDefaultValue=false)]
        public List<Shipment> Shipments { get; set; }

        /// <summary>
        /// An array of relations
        /// </summary>
        /// <value>An array of relations</value>
        [DataMember(Name="relations", EmitDefaultValue=false)]
        public List<Relation> Relations { get; set; }

        /// <summary>
        /// Gets or Sets Algorithm
        /// </summary>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public Algorithm Algorithm { get; set; }

        /// <summary>
        /// An array of objectives
        /// </summary>
        /// <value>An array of objectives</value>
        [DataMember(Name="objectives", EmitDefaultValue=false)]
        public List<Objective> Objectives { get; set; }

        /// <summary>
        /// An array of cost matrices
        /// </summary>
        /// <value>An array of cost matrices</value>
        [DataMember(Name="cost_matrices", EmitDefaultValue=false)]
        public List<CostMatrix> CostMatrices { get; set; }

        /// <summary>
        /// Gets or Sets Configuration
        /// </summary>
        [DataMember(Name="configuration", EmitDefaultValue=false)]
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Request {\n");
            sb.Append("  Vehicles: ").Append(Vehicles).Append("\n");
            sb.Append("  VehicleTypes: ").Append(VehicleTypes).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
            sb.Append("  Relations: ").Append(Relations).Append("\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Objectives: ").Append(Objectives).Append("\n");
            sb.Append("  CostMatrices: ").Append(CostMatrices).Append("\n");
            sb.Append("  Configuration: ").Append(Configuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Request);
        }

        /// <summary>
        /// Returns true if Request instances are equal
        /// </summary>
        /// <param name="input">Instance of Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vehicles == input.Vehicles ||
                    this.Vehicles != null &&
                    this.Vehicles.SequenceEqual(input.Vehicles)
                ) && 
                (
                    this.VehicleTypes == input.VehicleTypes ||
                    this.VehicleTypes != null &&
                    this.VehicleTypes.SequenceEqual(input.VehicleTypes)
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.Shipments == input.Shipments ||
                    this.Shipments != null &&
                    this.Shipments.SequenceEqual(input.Shipments)
                ) && 
                (
                    this.Relations == input.Relations ||
                    this.Relations != null &&
                    this.Relations.SequenceEqual(input.Relations)
                ) && 
                (
                    this.Algorithm == input.Algorithm ||
                    (this.Algorithm != null &&
                    this.Algorithm.Equals(input.Algorithm))
                ) && 
                (
                    this.Objectives == input.Objectives ||
                    this.Objectives != null &&
                    this.Objectives.SequenceEqual(input.Objectives)
                ) && 
                (
                    this.CostMatrices == input.CostMatrices ||
                    this.CostMatrices != null &&
                    this.CostMatrices.SequenceEqual(input.CostMatrices)
                ) && 
                (
                    this.Configuration == input.Configuration ||
                    (this.Configuration != null &&
                    this.Configuration.Equals(input.Configuration))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Vehicles != null)
                    hashCode = hashCode * 59 + this.Vehicles.GetHashCode();
                if (this.VehicleTypes != null)
                    hashCode = hashCode * 59 + this.VehicleTypes.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.Shipments != null)
                    hashCode = hashCode * 59 + this.Shipments.GetHashCode();
                if (this.Relations != null)
                    hashCode = hashCode * 59 + this.Relations.GetHashCode();
                if (this.Algorithm != null)
                    hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.Objectives != null)
                    hashCode = hashCode * 59 + this.Objectives.GetHashCode();
                if (this.CostMatrices != null)
                    hashCode = hashCode * 59 + this.CostMatrices.GetHashCode();
                if (this.Configuration != null)
                    hashCode = hashCode * 59 + this.Configuration.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}