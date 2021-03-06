//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace CompanyName.LanguageSm
{
	/// <summary>
	/// DomainRelationship ExampleModelHasElements
	/// Embedding relationship between the Model and Elements
	/// </summary>
	[DslDesign::DisplayNameResource("CompanyName.LanguageSm.ExampleModelHasElements.DisplayName", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("CompanyName.LanguageSm.ExampleModelHasElements.Description", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("7389c9e9-b5bb-478f-9347-5a8a2dc59454")]
	public partial class ExampleModelHasElements : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ExampleModelHasElements domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x7389c9e9, 0xb5bb, 0x478f, 0x93, 0x47, 0x5a, 0x8a, 0x2d, 0xc5, 0x94, 0x54);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ExampleModelHasElements link in the same Partition as the given ExampleModel
		/// </summary>
		/// <param name="source">ExampleModel to use as the source of the relationship.</param>
		/// <param name="target">ExampleElement to use as the target of the relationship.</param>
		public ExampleModelHasElements(ExampleModel source, ExampleElement target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ExampleModelHasElements.ExampleModelDomainRoleId, source), new DslModeling::RoleAssignment(ExampleModelHasElements.ElementDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleModelHasElements(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleModelHasElements(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleModelHasElements(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleModelHasElements(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region ExampleModel domain role code
		
		/// <summary>
		/// ExampleModel domain role Id.
		/// </summary>
		public static readonly global::System.Guid ExampleModelDomainRoleId = new global::System.Guid(0xbc57a4a6, 0xa1d7, 0x4e33, 0xbc, 0x1d, 0x03, 0xe9, 0x6a, 0xe9, 0xab, 0xc0);
		
		/// <summary>
		/// DomainRole ExampleModel
		/// </summary>
		[DslDesign::DisplayNameResource("CompanyName.LanguageSm.ExampleModelHasElements/ExampleModel.DisplayName", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("CompanyName.LanguageSm.ExampleModelHasElements/ExampleModel.Description", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Elements", PropertyDisplayNameKey="CompanyName.LanguageSm.ExampleModelHasElements/ExampleModel.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.PropagatesCopyToLinkAndOppositeRolePlayer, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("bc57a4a6-a1d7-4e33-bc1d-03e96ae9abc0")]
		public virtual ExampleModel ExampleModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleModel)DslModeling::DomainRoleInfo.GetRolePlayer(this, ExampleModelDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ExampleModelDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access ExampleModel of a ExampleElement
		/// <summary>
		/// Gets ExampleModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static ExampleModel GetExampleModel(ExampleElement element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, ElementDomainRoleId) as ExampleModel;
		}
		
		/// <summary>
		/// Sets ExampleModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetExampleModel(ExampleElement element, ExampleModel newExampleModel)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, ElementDomainRoleId, newExampleModel);
		}
		#endregion
		#region Element domain role code
		
		/// <summary>
		/// Element domain role Id.
		/// </summary>
		public static readonly global::System.Guid ElementDomainRoleId = new global::System.Guid(0xfa5670a5, 0x6ad6, 0x44dd, 0x92, 0x21, 0x28, 0x90, 0x13, 0x0e, 0x75, 0x79);
		
		/// <summary>
		/// DomainRole Element
		/// </summary>
		[DslDesign::DisplayNameResource("CompanyName.LanguageSm.ExampleModelHasElements/Element.DisplayName", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("CompanyName.LanguageSm.ExampleModelHasElements/Element.Description", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "ExampleModel", PropertyDisplayNameKey="CompanyName.LanguageSm.ExampleModelHasElements/Element.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("fa5670a5-6ad6-44dd-9221-2890130e7579")]
		public virtual ExampleElement Element
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleElement)DslModeling::DomainRoleInfo.GetRolePlayer(this, ElementDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ElementDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Elements of a ExampleModel
		/// <summary>
		/// Gets a list of Elements.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ExampleElement> GetElements(ExampleModel element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ExampleElement>, ExampleElement>(element, ExampleModelDomainRoleId);
		}
		#endregion
		#region ExampleModel link accessor
		/// <summary>
		/// Get the list of ExampleModelHasElements links to a ExampleModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::CompanyName.LanguageSm.ExampleModelHasElements> GetLinksToElements ( global::CompanyName.LanguageSm.ExampleModel exampleModelInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::CompanyName.LanguageSm.ExampleModelHasElements>(exampleModelInstance, global::CompanyName.LanguageSm.ExampleModelHasElements.ExampleModelDomainRoleId);
		}
		#endregion
		#region Element link accessor
		/// <summary>
		/// Get the ExampleModelHasElements link to a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::CompanyName.LanguageSm.ExampleModelHasElements GetLinkToExampleModel (global::CompanyName.LanguageSm.ExampleElement elementInstance)
		{
			global::System.Collections.Generic.IList<global::CompanyName.LanguageSm.ExampleModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::CompanyName.LanguageSm.ExampleModelHasElements>(elementInstance, global::CompanyName.LanguageSm.ExampleModelHasElements.ElementDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Element not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region ExampleModelHasElements instance accessors
		
		/// <summary>
		/// Get any ExampleModelHasElements links between a given ExampleModel and a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::CompanyName.LanguageSm.ExampleModelHasElements> GetLinks( global::CompanyName.LanguageSm.ExampleModel source, global::CompanyName.LanguageSm.ExampleElement target )
		{
			global::System.Collections.Generic.List<global::CompanyName.LanguageSm.ExampleModelHasElements> outLinks = new global::System.Collections.Generic.List<global::CompanyName.LanguageSm.ExampleModelHasElements>();
			global::System.Collections.Generic.IList<global::CompanyName.LanguageSm.ExampleModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::CompanyName.LanguageSm.ExampleModelHasElements>(source, global::CompanyName.LanguageSm.ExampleModelHasElements.ExampleModelDomainRoleId);
			foreach ( global::CompanyName.LanguageSm.ExampleModelHasElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one ExampleModelHasElements link between a given ExampleModeland a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::CompanyName.LanguageSm.ExampleModelHasElements GetLink( global::CompanyName.LanguageSm.ExampleModel source, global::CompanyName.LanguageSm.ExampleElement target )
		{
			global::System.Collections.Generic.IList<global::CompanyName.LanguageSm.ExampleModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::CompanyName.LanguageSm.ExampleModelHasElements>(source, global::CompanyName.LanguageSm.ExampleModelHasElements.ExampleModelDomainRoleId);
			foreach ( global::CompanyName.LanguageSm.ExampleModelHasElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace CompanyName.LanguageSm
{
	/// <summary>
	/// DomainRelationship ExampleElementReferencesTargets
	/// Reference relationship between Elements.
	/// </summary>
	[DslDesign::DisplayNameResource("CompanyName.LanguageSm.ExampleElementReferencesTargets.DisplayName", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("CompanyName.LanguageSm.ExampleElementReferencesTargets.Description", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship()]
	[DslModeling::DomainObjectId("bd183e7d-ed93-4fcc-8651-397d93df64cc")]
	public partial class ExampleElementReferencesTargets : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ExampleElementReferencesTargets domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xbd183e7d, 0xed93, 0x4fcc, 0x86, 0x51, 0x39, 0x7d, 0x93, 0xdf, 0x64, 0xcc);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ExampleElementReferencesTargets link in the same Partition as the given ExampleElement
		/// </summary>
		/// <param name="source">ExampleElement to use as the source of the relationship.</param>
		/// <param name="target">ExampleElement to use as the target of the relationship.</param>
		public ExampleElementReferencesTargets(ExampleElement source, ExampleElement target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ExampleElementReferencesTargets.SourceDomainRoleId, source), new DslModeling::RoleAssignment(ExampleElementReferencesTargets.TargetDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleElementReferencesTargets(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleElementReferencesTargets(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleElementReferencesTargets(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleElementReferencesTargets(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Source domain role code
		
		/// <summary>
		/// Source domain role Id.
		/// </summary>
		public static readonly global::System.Guid SourceDomainRoleId = new global::System.Guid(0xd2c04388, 0xee02, 0x4165, 0xb4, 0xa1, 0xef, 0x5b, 0x54, 0xb6, 0x50, 0x72);
		
		/// <summary>
		/// DomainRole Source
		/// Description for CompanyName.LanguageSm.ExampleRelationship.Target
		/// </summary>
		[DslDesign::DisplayNameResource("CompanyName.LanguageSm.ExampleElementReferencesTargets/Source.DisplayName", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("CompanyName.LanguageSm.ExampleElementReferencesTargets/Source.Description", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Targets", PropertyDisplayNameKey="CompanyName.LanguageSm.ExampleElementReferencesTargets/Source.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("d2c04388-ee02-4165-b4a1-ef5b54b65072")]
		public virtual ExampleElement Source
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleElement)DslModeling::DomainRoleInfo.GetRolePlayer(this, SourceDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, SourceDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Sources of a ExampleElement
		/// <summary>
		/// Gets a list of Sources.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ExampleElement> GetSources(ExampleElement element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ExampleElement>, ExampleElement>(element, TargetDomainRoleId);
		}
		#endregion
		#region Target domain role code
		
		/// <summary>
		/// Target domain role Id.
		/// </summary>
		public static readonly global::System.Guid TargetDomainRoleId = new global::System.Guid(0x092dc742, 0xcd76, 0x4765, 0xae, 0x3b, 0x48, 0xb5, 0x87, 0xaa, 0x3e, 0x9e);
		
		/// <summary>
		/// DomainRole Target
		/// Description for CompanyName.LanguageSm.ExampleRelationship.Source
		/// </summary>
		[DslDesign::DisplayNameResource("CompanyName.LanguageSm.ExampleElementReferencesTargets/Target.DisplayName", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("CompanyName.LanguageSm.ExampleElementReferencesTargets/Target.Description", typeof(global::CompanyName.LanguageSm.LanguageSmDomainModel), "CompanyName.LanguageSm.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "Sources", PropertyDisplayNameKey="CompanyName.LanguageSm.ExampleElementReferencesTargets/Target.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("092dc742-cd76-4765-ae3b-48b587aa3e9e")]
		public virtual ExampleElement Target
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleElement)DslModeling::DomainRoleInfo.GetRolePlayer(this, TargetDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, TargetDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Targets of a ExampleElement
		/// <summary>
		/// Gets a list of Targets.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ExampleElement> GetTargets(ExampleElement element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ExampleElement>, ExampleElement>(element, SourceDomainRoleId);
		}
		#endregion
		#region Source link accessor
		/// <summary>
		/// Get the list of ExampleElementReferencesTargets links to a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::CompanyName.LanguageSm.ExampleElementReferencesTargets> GetLinksToTargets ( global::CompanyName.LanguageSm.ExampleElement sourceInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::CompanyName.LanguageSm.ExampleElementReferencesTargets>(sourceInstance, global::CompanyName.LanguageSm.ExampleElementReferencesTargets.SourceDomainRoleId);
		}
		#endregion
		#region Target link accessor
		/// <summary>
		/// Get the list of ExampleElementReferencesTargets links to a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::CompanyName.LanguageSm.ExampleElementReferencesTargets> GetLinksToSources ( global::CompanyName.LanguageSm.ExampleElement targetInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::CompanyName.LanguageSm.ExampleElementReferencesTargets>(targetInstance, global::CompanyName.LanguageSm.ExampleElementReferencesTargets.TargetDomainRoleId);
		}
		#endregion
		#region ExampleElementReferencesTargets instance accessors
		
		/// <summary>
		/// Get any ExampleElementReferencesTargets links between a given ExampleElement and a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::CompanyName.LanguageSm.ExampleElementReferencesTargets> GetLinks( global::CompanyName.LanguageSm.ExampleElement source, global::CompanyName.LanguageSm.ExampleElement target )
		{
			global::System.Collections.Generic.List<global::CompanyName.LanguageSm.ExampleElementReferencesTargets> outLinks = new global::System.Collections.Generic.List<global::CompanyName.LanguageSm.ExampleElementReferencesTargets>();
			global::System.Collections.Generic.IList<global::CompanyName.LanguageSm.ExampleElementReferencesTargets> links = DslModeling::DomainRoleInfo.GetElementLinks<global::CompanyName.LanguageSm.ExampleElementReferencesTargets>(source, global::CompanyName.LanguageSm.ExampleElementReferencesTargets.SourceDomainRoleId);
			foreach ( global::CompanyName.LanguageSm.ExampleElementReferencesTargets link in links )
			{
				if ( target.Equals(link.Target) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one ExampleElementReferencesTargets link between a given ExampleElementand a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::CompanyName.LanguageSm.ExampleElementReferencesTargets GetLink( global::CompanyName.LanguageSm.ExampleElement source, global::CompanyName.LanguageSm.ExampleElement target )
		{
			global::System.Collections.Generic.IList<global::CompanyName.LanguageSm.ExampleElementReferencesTargets> links = DslModeling::DomainRoleInfo.GetElementLinks<global::CompanyName.LanguageSm.ExampleElementReferencesTargets>(source, global::CompanyName.LanguageSm.ExampleElementReferencesTargets.SourceDomainRoleId);
			foreach ( global::CompanyName.LanguageSm.ExampleElementReferencesTargets link in links )
			{
				if ( target.Equals(link.Target) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
