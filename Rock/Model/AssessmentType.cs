﻿// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Runtime.Serialization;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Represents an assessment.
    /// </summary>
    [RockDomain( "CRM" )]
    [Table( "AssessmentType" )]
    [DataContract]
    public class AssessmentType : Model<AssessmentType>, IHasActiveFlag
    {
        #region Entity Properties

        /// <summary>
        ///Title  
        /// /// </summary>
        /// <value>
        /// A <see cref="System.String"/> <c>false</c>.
        /// </value>
        [Required]
        [MaxLength(100)]
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        ///Description  
        /// /// </summary>
        /// <value>
        /// A <see cref="System.String"/> <c>false</c>.
        /// </value>
        [Required]
        [StringLength( 100, MinimumLength = 3 )]
        [MaxLength]
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        ///AssessmentResultsPath  
        /// /// </summary>
        /// <value>
        /// A <see cref="System.String"/> <c>false</c>.
        /// </value>
        [Required]
        [MaxLength( 250 )]
        [DataMember]
        public string AssessmentPath { get; set; }

        /// <summary>
        ///AssessmentResultsPath  
        /// /// </summary>
        /// <value>
        /// A <see cref="System.String"/> <c>false</c>.
        /// </value>
        [MaxLength( 250 )]
        [DataMember]
        public string AssessmentResultsPath { get; set; }

        /// <summary>
        ///IsActive  
        /// /// </summary>
        /// <value>
        /// A <see cref="System.Boolean"/> <c>false</c>.
        /// </value>
        [Required]
        [DataMember]
        public Boolean IsActive { get; set; }

        /// <summary>
        ///RequiresRequest  
        /// /// </summary>
        /// <value>
        /// A <see cref="System.Boolean"/> <c>false</c>.
        /// </value>
        [Required]
        [DataMember]
        public Boolean RequiresRequest { get; set; }

        /// <summary>
        ///MinimumDaysToRetake
        /// /// </summary>
        /// <value>
        /// A <see cref="System.int"/> <c>false</c>.
        /// </value>
        [DataMember]
        public int MinimumDaysToRetake { get; set; }

        /// <summary>
        ///ValidDuration
        /// /// </summary>
        /// <value>
        /// A <see cref="System.int"/> <c>false</c>.
        /// </value>
        [DataMember]
        public int ValidDuration { get; set; }


        /// <summary>
        /// Gets or sets a flag indicating if this AssessmentType is a part of the Rock core system/framework. This property is required.
        /// </summary>
        /// <value>
        /// A <see cref="System.Boolean"/> value that is <c>true</c> if this AssessmentType is part of the Rock core system/framework; otherwise <c>false</c>.
        /// </value>
        [Required]
        [DataMember( IsRequired = true )]
        public bool IsSystem { get; set; }

        #endregion

        #region Virtual Properties

        /// <summary>
        ///Collection of Assessments for each Assessment Type
        /// </summary>
        [DataMember]
        public virtual ICollection<Assessment> Assessments
        {
            get { return _assessments; }
            set { _assessments = value; }
        }
        private ICollection<Assessment> _assessments;

        #endregion
    }

    #region Entity Configuration

    /// <summary>
    /// AssessmentType Configuration class.
    /// </summary>
    public partial class AssessmentTypeConfiguration : EntityTypeConfiguration<AssessmentType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentTypeConfiguration" /> class.
        /// </summary>
        public AssessmentTypeConfiguration()
        {
        }
    }

    #endregion
}
