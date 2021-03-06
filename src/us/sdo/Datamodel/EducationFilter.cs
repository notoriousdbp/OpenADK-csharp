// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Datamodel{

/// <summary>An EducationFilter</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.1</para>
/// </remarks>
[Serializable]
public class EducationFilter : SifElement
{
	/// <summary>
	/// Creates an instance of an EducationFilter
	/// </summary>
	public EducationFilter() : base ( DatamodelDTD.EDUCATIONFILTER ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected EducationFilter( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;MediaTypes&gt;</c> element.
	/// </summary>
	/// <value> A MediaTypes </value>
	/// <remarks>
	/// <para>To remove the <c>MediaTypes</c>, set <c>MediaTypes</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public MediaTypes MediaTypes
	{
		get
		{
			return (MediaTypes)GetChild( DatamodelDTD.EDUCATIONFILTER_MEDIATYPES);
		}
		set
		{
			RemoveChild( DatamodelDTD.EDUCATIONFILTER_MEDIATYPES);
			if( value != null)
			{
				AddChild( DatamodelDTD.EDUCATIONFILTER_MEDIATYPES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Applicable grade levels as defined by SIF."</para>
	/// <para>To remove the <c>GradeLevels</c>, set <c>GradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public GradeLevels GradeLevels
	{
		get
		{
			return (GradeLevels)GetChild( DatamodelDTD.EDUCATIONFILTER_GRADELEVELS);
		}
		set
		{
			RemoveChild( DatamodelDTD.EDUCATIONFILTER_GRADELEVELS);
			if( value != null)
			{
				AddChild( DatamodelDTD.EDUCATIONFILTER_GRADELEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SubjectAreas&gt;</c> element.
	/// </summary>
	/// <value> A SubjectAreas </value>
	/// <remarks>
	/// <para>To remove the <c>SubjectAreas</c>, set <c>SubjectAreas</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public SubjectAreas SubjectAreas
	{
		get
		{
			return (SubjectAreas)GetChild( DatamodelDTD.EDUCATIONFILTER_SUBJECTAREAS);
		}
		set
		{
			RemoveChild( DatamodelDTD.EDUCATIONFILTER_SUBJECTAREAS);
			if( value != null)
			{
				AddChild( DatamodelDTD.EDUCATIONFILTER_SUBJECTAREAS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;InterestLevels&gt;</c> element.
	/// </summary>
	/// <value> An InterestLevels </value>
	/// <remarks>
	/// <para>To remove the <c>InterestLevels</c>, set <c>InterestLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public InterestLevels InterestLevels
	{
		get
		{
			return (InterestLevels)GetChild( DatamodelDTD.EDUCATIONFILTER_INTERESTLEVELS);
		}
		set
		{
			RemoveChild( DatamodelDTD.EDUCATIONFILTER_INTERESTLEVELS);
			if( value != null)
			{
				AddChild( DatamodelDTD.EDUCATIONFILTER_INTERESTLEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LearningStandardItems&gt;</c> element.
	/// </summary>
	/// <value> A LearningStandardItems </value>
	/// <remarks>
	/// <para>To remove the <c>LearningStandardItems</c>, set <c>LearningStandardItems</c> to <c>null</c></para>
	/// <para>Version: 2.1</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public LearningStandardItems LearningStandardItems
	{
		get
		{
			return (LearningStandardItems)GetChild( DatamodelDTD.EDUCATIONFILTER_LEARNINGSTANDARDITEMS);
		}
		set
		{
			RemoveChild( DatamodelDTD.EDUCATIONFILTER_LEARNINGSTANDARDITEMS);
			if( value != null)
			{
				AddChild( DatamodelDTD.EDUCATIONFILTER_LEARNINGSTANDARDITEMS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;BloomsTaxonomyLevels&gt;</c> element.
	/// </summary>
	/// <value> A BloomsTaxonomyLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This is a taxonomy of educational objectives based on three "domains:" Affective, Psychomotor, and Cognitive. For the purposes of assigning attributes to learning resources, the SIF specification is limited to the cognitive domain, including knowledge, comprehension, application, analysis, synthesis and evaluation. "</para>
	/// <para>To remove the <c>BloomsTaxonomyLevels</c>, set <c>BloomsTaxonomyLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public BloomsTaxonomyLevels BloomsTaxonomyLevels
	{
		get
		{
			return (BloomsTaxonomyLevels)GetChild( DatamodelDTD.EDUCATIONFILTER_BLOOMSTAXONOMYLEVELS);
		}
		set
		{
			RemoveChild( DatamodelDTD.EDUCATIONFILTER_BLOOMSTAXONOMYLEVELS);
			if( value != null)
			{
				AddChild( DatamodelDTD.EDUCATIONFILTER_BLOOMSTAXONOMYLEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MultipleIntelligences&gt;</c> element.
	/// </summary>
	/// <value> A MultipleIntelligences </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "An educational theory that describes at least eight different kinds of "intelligences." These include linguistic, logical-mathematical, spatial, bodily-kinesthetic, musical intelligence, interpersonal, intrapersonal and naturalist."</para>
	/// <para>To remove the <c>MultipleIntelligences</c>, set <c>MultipleIntelligences</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public MultipleIntelligences MultipleIntelligences
	{
		get
		{
			return (MultipleIntelligences)GetChild( DatamodelDTD.EDUCATIONFILTER_MULTIPLEINTELLIGENCES);
		}
		set
		{
			RemoveChild( DatamodelDTD.EDUCATIONFILTER_MULTIPLEINTELLIGENCES);
			if( value != null)
			{
				AddChild( DatamodelDTD.EDUCATIONFILTER_MULTIPLEINTELLIGENCES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;InstructionalStrategies&gt;</c> element.
	/// </summary>
	/// <value> An InstructionalStrategies </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The various ways that instruction is delivered to achieve learning objectives and concepts."</para>
	/// <para>To remove the <c>InstructionalStrategies</c>, set <c>InstructionalStrategies</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.2</para>
	/// </remarks>
	public InstructionalStrategies InstructionalStrategies
	{
		get
		{
			return (InstructionalStrategies)GetChild( DatamodelDTD.EDUCATIONFILTER_INSTRUCTIONALSTRATEGIES);
		}
		set
		{
			RemoveChild( DatamodelDTD.EDUCATIONFILTER_INSTRUCTIONALSTRATEGIES);
			if( value != null)
			{
				AddChild( DatamodelDTD.EDUCATIONFILTER_INSTRUCTIONALSTRATEGIES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LearningObjectives&gt;</c> element.
	/// </summary>
	/// <value> A LearningObjectives </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Description of learning objective(s) for this lesson, i.e., "Student will be able to use Pythagorean Theorem."—equates to 'benchmark' or 'goal' or other terminology"</para>
	/// <para>To remove the <c>LearningObjectives</c>, set <c>LearningObjectives</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public LearningObjectives LearningObjectives
	{
		get
		{
			return (LearningObjectives)GetChild( DatamodelDTD.EDUCATIONFILTER_LEARNINGOBJECTIVES);
		}
		set
		{
			RemoveChild( DatamodelDTD.EDUCATIONFILTER_LEARNINGOBJECTIVES);
			if( value != null)
			{
				AddChild( DatamodelDTD.EDUCATIONFILTER_LEARNINGOBJECTIVES, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ResourceTypes&gt;</c> element.</summary>
	/// <param name="ResourceType">A ResourceType</param>
	///<remarks>
	/// <para>This form of <c>setResourceTypes</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ResourceTypes</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetResourceTypes( ResourceTypeType ResourceType ) {
		RemoveChild( DatamodelDTD.EDUCATIONFILTER_RESOURCETYPES);
		AddChild( DatamodelDTD.EDUCATIONFILTER_RESOURCETYPES, new ResourceTypes( ResourceType ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ResourceTypes&gt;</c> element.
	/// </summary>
	/// <value> A ResourceTypes </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Type of resource"</para>
	/// <para>To remove the <c>ResourceTypes</c>, set <c>ResourceTypes</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ResourceTypes ResourceTypes
	{
		get
		{
			return (ResourceTypes)GetChild( DatamodelDTD.EDUCATIONFILTER_RESOURCETYPES);
		}
		set
		{
			RemoveChild( DatamodelDTD.EDUCATIONFILTER_RESOURCETYPES);
			if( value != null)
			{
				AddChild( DatamodelDTD.EDUCATIONFILTER_RESOURCETYPES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Summary&gt;</c> element.
	/// </summary>
	/// <value> The <c>Summary</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A summary of the content."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Summary
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.EDUCATIONFILTER_SUMMARY ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.EDUCATIONFILTER_SUMMARY, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Title&gt;</c> element.
	/// </summary>
	/// <value> The <c>Title</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The title of the content."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Title
	{
		get
		{
			return (string) GetSifSimpleFieldValue( DatamodelDTD.EDUCATIONFILTER_TITLE ) ;
		}
		set
		{
			SetFieldValue( DatamodelDTD.EDUCATIONFILTER_TITLE, new SifString( value ), value );
		}
	}

}}
