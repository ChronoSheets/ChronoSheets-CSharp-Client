/* 
 * ChronoSheets API
 *
 * <div style='font-size: 14px!important;font-family: Open Sans,sans-serif!important;color: #3b4151!important;'><p>      ChronoSheets is a flexible timesheet solution for small to medium businesses, it is free for small teams of up to 3 and there are iOS and Android apps available.  Use the ChronoSheets API to create your own custom integrations.  Before starting, sign up for a ChronoSheets account at <a target='_BLANK' href='http://tsheets.xyz/signup'>http://tsheets.xyz/signup</a>.  </p></div><div id='cs-extra-info'></div>
 *
 * The version of the OpenAPI document: v1
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
using OpenAPIDateConverter = ChronoSheetsAPI.Client.OpenAPIDateConverter;

namespace ChronoSheetsAPI.ChronoSheetsClientLibModel
{
    /// <summary>
    /// OrganisationPricingPlan
    /// </summary>
    [DataContract]
    public partial class OrganisationPricingPlan :  IEquatable<OrganisationPricingPlan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganisationPricingPlan" /> class.
        /// </summary>
        /// <param name="planId">planId.</param>
        /// <param name="quantity">quantity.</param>
        public OrganisationPricingPlan(string planId = default(string), int quantity = default(int))
        {
            this.PlanId = planId;
            this.Quantity = quantity;
        }
        
        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name="PlanId", EmitDefaultValue=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganisationPricingPlan {\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrganisationPricingPlan);
        }

        /// <summary>
        /// Returns true if OrganisationPricingPlan instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganisationPricingPlan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganisationPricingPlan input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.PlanId != null)
                    hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
