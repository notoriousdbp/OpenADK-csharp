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

namespace OpenADK.Library.us.Instr{

/// <summary>Response to Intervention (RTI) is a multi-tier approach to the early identification and assistance of students who are having learning and/or behavioral needs. This object records the individual learner information for an assigned ResponseToIntervention.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class RTIResults : SifDataObject
{
	/// <summary>
	/// Creates an instance of a RTIResults
	/// </summary>
	public RTIResults() : base( Adk.SifVersion, InstrDTD.RTIRESULTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The Id (GUID) that uniquely identifies the results of a particular Response to Intervention.</param>
	///<param name="studentPersonalRefId">The Id (GUID) of the student being administered the intervention..</param>
	///<param name="studentPlacementRefId">The Id (GUID) that references the StudentPlacement Object that contains information that describes a specific instructional, related or transitional service that has been prescribed or recommended in the program plan developed for a student who has been placed in an individualized special program.</param>
	///<param name="responseToInterventionRefId">The Id (GUID) of the reference to the ResponseToIntervention that has been assigned for this individual learner.</param>
	///
	public RTIResults( string refId, string studentPersonalRefId, string studentPlacementRefId, string responseToInterventionRefId ) : base( Adk.SifVersion, InstrDTD.RTIRESULTS )
	{
		this.RefId = refId;
		this.StudentPersonalRefId = studentPersonalRefId;
		this.StudentPlacementRefId = studentPlacementRefId;
		this.ResponseToInterventionRefId = responseToInterventionRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected RTIResults( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InstrDTD.RTIRESULTS_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The Id (GUID) that uniquely identifies the results of a particular Response to Intervention."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.RTIRESULTS_REFID ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.RTIRESULTS_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>StudentPersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The Id (GUID) of the student being administered the intervention.."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.RTIRESULTS_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.RTIRESULTS_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>StudentPlacementRefId</c> attribute.
	/// </summary>
	/// <value> The <c>StudentPlacementRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The Id (GUID) that references the StudentPlacement Object that contains information that describes a specific instructional, related or transitional service that has been prescribed or recommended in the program plan developed for a student who has been placed in an individualized special program."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string StudentPlacementRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.RTIRESULTS_STUDENTPLACEMENTREFID ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.RTIRESULTS_STUDENTPLACEMENTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>ResponseToInterventionRefId</c> attribute.
	/// </summary>
	/// <value> The <c>ResponseToInterventionRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The Id (GUID) of the reference to the ResponseToIntervention that has been assigned for this individual learner."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ResponseToInterventionRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.RTIRESULTS_RESPONSETOINTERVENTIONREFID ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.RTIRESULTS_RESPONSETOINTERVENTIONREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RTILocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>RTILocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A local ID that may be used to identify this intervention for the student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string RTILocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.RTIRESULTS_RTILOCALID ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.RTIRESULTS_RTILOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Intervention&gt;</c> element.
	/// </summary>
	/// <value> The <c>Intervention</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Naming of the intervention."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string Intervention
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.RTIRESULTS_INTERVENTION ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.RTIRESULTS_INTERVENTION, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;PerformanceIndicators&gt;</c> element.</summary>
	/// <param name="PerformanceIndicator">The specific measurement goal at the end of the intervention that each student should reach.</param>
	///<remarks>
	/// <para>This form of <c>setPerformanceIndicators</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PerformanceIndicators</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetPerformanceIndicators( PerformanceIndicator PerformanceIndicator ) {
		RemoveChild( InstrDTD.RTIRESULTS_PERFORMANCEINDICATORS);
		AddChild( InstrDTD.RTIRESULTS_PERFORMANCEINDICATORS, new PerformanceIndicators( PerformanceIndicator ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PerformanceIndicators&gt;</c> element.
	/// </summary>
	/// <value> A PerformanceIndicators </value>
	/// <remarks>
	/// <para>To remove the <c>PerformanceIndicators</c>, set <c>PerformanceIndicators</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public PerformanceIndicators PerformanceIndicators
	{
		get
		{
			return (PerformanceIndicators)GetChild( InstrDTD.RTIRESULTS_PERFORMANCEINDICATORS);
		}
		set
		{
			RemoveChild( InstrDTD.RTIRESULTS_PERFORMANCEINDICATORS);
			if( value != null)
			{
				AddChild( InstrDTD.RTIRESULTS_PERFORMANCEINDICATORS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Measurements&gt;</c> element.</summary>
	/// <param name="MeasurementTool">The specific tool that will be used to gather data about how the student is improving.</param>
	/// <param name="FrequencyofMeasure">The frequency of the measuement.</param>
	///<remarks>
	/// <para>This form of <c>setMeasurements</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Measurements</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetMeasurements( string MeasurementTool, FrequencyTimeCode FrequencyofMeasure ) {
		RemoveChild( InstrDTD.RTIRESULTS_MEASUREMENTS);
		AddChild( InstrDTD.RTIRESULTS_MEASUREMENTS, new MeasurementsRTI( MeasurementTool, FrequencyofMeasure ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Measurements&gt;</c> element.
	/// </summary>
	/// <value> A MeasurementsRTI </value>
	/// <remarks>
	/// <para>To remove the <c>MeasurementsRTI</c>, set <c>Measurements</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public MeasurementsRTI Measurements
	{
		get
		{
			return (MeasurementsRTI)GetChild( InstrDTD.RTIRESULTS_MEASUREMENTS);
		}
		set
		{
			RemoveChild( InstrDTD.RTIRESULTS_MEASUREMENTS);
			if( value != null)
			{
				AddChild( InstrDTD.RTIRESULTS_MEASUREMENTS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Baselines&gt;</c> element.</summary>
	/// <param name="Baseline">The pre-assessment data to evaluate the student on the learning objective.</param>
	///<remarks>
	/// <para>This form of <c>setBaselines</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Baselines</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetBaselines( Baseline Baseline ) {
		RemoveChild( InstrDTD.RTIRESULTS_BASELINES);
		AddChild( InstrDTD.RTIRESULTS_BASELINES, new Baselines( Baseline ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Baselines&gt;</c> element.
	/// </summary>
	/// <value> A Baselines </value>
	/// <remarks>
	/// <para>To remove the <c>Baselines</c>, set <c>Baselines</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public Baselines Baselines
	{
		get
		{
			return (Baselines)GetChild( InstrDTD.RTIRESULTS_BASELINES);
		}
		set
		{
			RemoveChild( InstrDTD.RTIRESULTS_BASELINES);
			if( value != null)
			{
				AddChild( InstrDTD.RTIRESULTS_BASELINES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Targets&gt;</c> element.
	/// </summary>
	/// <value> A Targets </value>
	/// <remarks>
	/// <para>To remove the <c>Targets</c>, set <c>Targets</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public Targets Targets
	{
		get
		{
			return (Targets)GetChild( InstrDTD.RTIRESULTS_TARGETS);
		}
		set
		{
			RemoveChild( InstrDTD.RTIRESULTS_TARGETS);
			if( value != null)
			{
				AddChild( InstrDTD.RTIRESULTS_TARGETS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Results&gt;</c> element.</summary>
	/// <param name="Result">This represents the results based on each measurement period.</param>
	///<remarks>
	/// <para>This form of <c>setResults</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Results</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetResults( Result Result ) {
		RemoveChild( InstrDTD.RTIRESULTS_RESULTS);
		AddChild( InstrDTD.RTIRESULTS_RESULTS, new Results( Result ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Results&gt;</c> element.
	/// </summary>
	/// <value> A Results </value>
	/// <remarks>
	/// <para>To remove the <c>Results</c>, set <c>Results</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public Results Results
	{
		get
		{
			return (Results)GetChild( InstrDTD.RTIRESULTS_RESULTS);
		}
		set
		{
			RemoveChild( InstrDTD.RTIRESULTS_RESULTS);
			if( value != null)
			{
				AddChild( InstrDTD.RTIRESULTS_RESULTS, value );
			}
		}
	}

}}