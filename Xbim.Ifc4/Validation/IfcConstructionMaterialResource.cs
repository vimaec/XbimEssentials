using System;
using Microsoft.Extensions.Logging;
using Xbim.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.ConstructionMgmtDomain
{
	public partial class IfcConstructionMaterialResource : IExpressValidatable
	{
		public enum IfcConstructionMaterialResourceClause
		{
			CorrectPredefinedType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcConstructionMaterialResourceClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcConstructionMaterialResourceClause.CorrectPredefinedType:
						retVal = !(Functions.EXISTS(PredefinedType)) || (PredefinedType != IfcConstructionMaterialResourceTypeEnum.USERDEFINED) || ((PredefinedType == IfcConstructionMaterialResourceTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcObject*/.ObjectType));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Xbim.Ifc4.ConstructionMgmtDomain.IfcConstructionMaterialResource>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcConstructionMaterialResource.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcConstructionMaterialResourceClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcConstructionMaterialResource.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
