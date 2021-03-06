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

namespace OpenADK.Library.us.Assessment{

/// <summary>This object is designed to allow software systems to provide item detail information such as the stem of the item, the distractors, the stimuli, etc. This initial version of the object does not deal with presentation aspects of the item. Instead it focuses on the item content and characteristics needed to enable interoperability and the usage of item-level information in the improvement of learning and instruction.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Sif3AssessmentItem : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Sif3AssessmentItem
	/// </summary>
	public Sif3AssessmentItem() : base( Adk.SifVersion, AssessmentDTD.SIF3ASSESSMENTITEM ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">A RefId</param>
	///<param name="responseType">A value that indicates the response type for the item.</param>
	///
	public Sif3AssessmentItem( string refId, ResponseType responseType ) : base( Adk.SifVersion, AssessmentDTD.SIF3ASSESSMENTITEM )
	{
		this.RefId = refId;
		this.SetResponseType( responseType );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Sif3AssessmentItem( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.SIF3ASSESSMENTITEM_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>ResponseType</c> attribute.
	/// </summary>
	/// <value> The <c>ResponseType</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A value that indicates the response type for the item."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ResponseType
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_RESPONSETYPE );
		}
		set
		{
			SetField( AssessmentDTD.SIF3ASSESSMENTITEM_RESPONSETYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>ResponseType</c> attribute.
	/// </summary>
	/// <param name="val">A ResponseType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A value that indicates the response type for the item."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetResponseType( ResponseType val )
	{
		SetField( AssessmentDTD.SIF3ASSESSMENTITEM_RESPONSETYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemVersion&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemVersion</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This will identify the version of the item that this object represents. New versions of the item will generate new RefIds and therefore new instances of the object. The format of the version number is defined by the assessment provider."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ItemVersion
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMVERSION ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMVERSION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemPublishDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemPublishDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date that this version of the item was published (published means made available for use). If the ItemVersion is provided, then this date should also be provided."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? ItemPublishDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMPUBLISHDATE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMPUBLISHDATE, new SifDateTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemName&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name or short description of the item."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ItemName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMNAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMNAME, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentIdentifiers&gt;</c> element.</summary>
	/// <param name="AssessmentIdentifier">A list of all assessment identifiers that may be associated with this assessment.</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentIdentifiers</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentIdentifiers</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentIdentifiers( AssessmentIdentifier AssessmentIdentifier ) {
		RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTIDENTIFIERS);
		AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTIDENTIFIERS, new AssessmentIdentifiers( AssessmentIdentifier ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentIdentifiers&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentIdentifiers </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "A list of all assessment identifiers that may be associated with this assessment"</para>
	/// <para>To remove the <c>AssessmentIdentifiers</c>, set <c>AssessmentIdentifiers</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssessmentIdentifiers AssessmentIdentifiers
	{
		get
		{
			return (AssessmentIdentifiers)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTIDENTIFIERS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTIDENTIFIERS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTIDENTIFIERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentSubjects&gt;</c> element.
	/// </summary>
	/// <value> A SubjectAreaList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The assessment may be designed to measure specific subject areas. Note that grade levels are also
	///                 included in the Assessment Form object. Specific forms of an assessment may have more granularity.
	///             "</para>
	/// <para>To remove the <c>SubjectAreaList</c>, set <c>AssessmentSubjects</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public SubjectAreaList AssessmentSubjects
	{
		get
		{
			return (SubjectAreaList)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTSUBJECTS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTSUBJECTS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTSUBJECTS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentGradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The assessment may be designed for specific grade levels. Note that grade levels are also included in
	///                 the Assessment Form object. Specific forms of an assessment may have more granularity.
	///             "</para>
	/// <para>To remove the <c>GradeLevels</c>, set <c>AssessmentGradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public GradeLevels AssessmentGradeLevels
	{
		get
		{
			return (GradeLevels)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTGRADELEVELS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTGRADELEVELS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTGRADELEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentLanguages&gt;</c> element.
	/// </summary>
	/// <value> A LanguageList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The assessment may be available in multiple languages. This list will indicate which languages are
	///                 available.
	///             "</para>
	/// <para>To remove the <c>LanguageList</c>, set <c>AssessmentLanguages</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public LanguageList AssessmentLanguages
	{
		get
		{
			return (LanguageList)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTLANGUAGES);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTLANGUAGES);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTLANGUAGES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LearningStandardItems&gt;</c> element.
	/// </summary>
	/// <value> A LearningStandardItems </value>
	/// <remarks>
	/// <para>To remove the <c>LearningStandardItems</c>, set <c>LearningStandardItems</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public LearningStandardItems LearningStandardItems
	{
		get
		{
			return (LearningStandardItems)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_LEARNINGSTANDARDITEMS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_LEARNINGSTANDARDITEMS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_LEARNINGSTANDARDITEMS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentItemAssetRefIds&gt;</c> element.</summary>
	/// <param name="AssessmentItemAssetRefId">Reference to an asset used by this item.</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentItemAssetRefIds</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentItemAssetRefIds</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentItemAssetRefIds( AssessmentItemAssetRefId AssessmentItemAssetRefId ) {
		RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMASSETREFIDS);
		AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMASSETREFIDS, new AssessmentItemAssetRefIds( AssessmentItemAssetRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentItemAssetRefIds&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentItemAssetRefIds </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "A list of all content assets that are associated with the item. Assets could include stimuli such as reading passages, charts, maps, etc. as well as supporting material such as formula sheets."</para>
	/// <para>To remove the <c>AssessmentItemAssetRefIds</c>, set <c>AssessmentItemAssetRefIds</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssessmentItemAssetRefIds AssessmentItemAssetRefIds
	{
		get
		{
			return (AssessmentItemAssetRefIds)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMASSETREFIDS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMASSETREFIDS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMASSETREFIDS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Stem&gt;</c> element.</summary>
	/// <param name="MimeType">MIME type to indicate the content type.</param>
	///<remarks>
	/// <para>This form of <c>setStem</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Stem</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetStem( string MimeType ) {
		RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_STEM);
		AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_STEM, new AbstractContentElementType( MimeType ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Stem&gt;</c> element.
	/// </summary>
	/// <value> An AbstractContentElementType </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The question, task, or statement that prompts a response from the test taker."</para>
	/// <para>To remove the <c>AbstractContentElementType</c>, set <c>Stem</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AbstractContentElementType Stem
	{
		get
		{
			return (AbstractContentElementType)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_STEM);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_STEM);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_STEM, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ResponseChoices&gt;</c> element.</summary>
	/// <param name="Choice">A Choice</param>
	///<remarks>
	/// <para>This form of <c>setResponseChoices</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ResponseChoices</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetResponseChoices( Choice Choice ) {
		RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_RESPONSECHOICES);
		AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_RESPONSECHOICES, new ResponseChoices( Choice ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ResponseChoices&gt;</c> element.
	/// </summary>
	/// <value> A ResponseChoices </value>
	/// <remarks>
	/// <para>To remove the <c>ResponseChoices</c>, set <c>ResponseChoices</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ResponseChoices ResponseChoices
	{
		get
		{
			return (ResponseChoices)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_RESPONSECHOICES);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_RESPONSECHOICES);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_RESPONSECHOICES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemFeedbackCorrect&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemFeedbackCorrect</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Feedback can be provided for the item if the item is correct."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ItemFeedbackCorrect
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMFEEDBACKCORRECT ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMFEEDBACKCORRECT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemFeedbackIncorrect&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemFeedbackIncorrect</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Feedback can be provided for the item if the item is incorrect."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ItemFeedbackIncorrect
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMFEEDBACKINCORRECT ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMFEEDBACKINCORRECT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemFeedbackHint&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemFeedbackHint</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A hint is provided to the test taker during testing, either on request or upon an incorrect response as determined by the test design."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ItemFeedbackHint
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMFEEDBACKHINT ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMFEEDBACKHINT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemScoreMaximum&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemScoreMaximum</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The maximum item score possible for this item."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ItemScoreMaximum
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMSCOREMAXIMUM ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMSCOREMAXIMUM, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemScoreMinimum&gt;</c> element.
	/// </summary>
	/// <value> The <c>ItemScoreMinimum</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The minimum item score possible for this item."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string ItemScoreMinimum
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMSCOREMINIMUM ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMSCOREMINIMUM, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;ItemRubricIds&gt;</c> element.</summary>
	/// <param name="ItemRubricId">If this item is scored using a rubric, this will identify the specific rubric used.</param>
	///<remarks>
	/// <para>This form of <c>setItemRubricIds</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ItemRubricIds</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetItemRubricIds( ItemRubricId ItemRubricId ) {
		RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMRUBRICIDS);
		AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMRUBRICIDS, new ItemRubricIds( ItemRubricId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ItemRubricIds&gt;</c> element.
	/// </summary>
	/// <value> An ItemRubricIds </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "A list of all rubric Ids for rubrics that may be used to evaluate an item response. Typically used for open ended items (such as essays)."</para>
	/// <para>To remove the <c>ItemRubricIds</c>, set <c>ItemRubricIds</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public ItemRubricIds ItemRubricIds
	{
		get
		{
			return (ItemRubricIds)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMRUBRICIDS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMRUBRICIDS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ITEMRUBRICIDS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;AssessmentItemBanks&gt;</c> element.</summary>
	/// <param name="AssessmentItemBank">A wrapper for the Item Bank elements.</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentItemBanks</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssessmentItemBanks</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssessmentItemBanks( AssessmentItemBank AssessmentItemBank ) {
		RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMBANKS);
		AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMBANKS, new AssessmentItemBanks( AssessmentItemBank ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentItemBanks&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentItemBanks </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Assessments may be part of one or more item banks."</para>
	/// <para>To remove the <c>AssessmentItemBanks</c>, set <c>AssessmentItemBanks</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssessmentItemBanks AssessmentItemBanks
	{
		get
		{
			return (AssessmentItemBanks)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMBANKS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMBANKS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMBANKS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentItemPlatforms&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentItemPlatforms </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentItemPlatforms</c>, set <c>AssessmentItemPlatforms</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssessmentItemPlatforms AssessmentItemPlatforms
	{
		get
		{
			return (AssessmentItemPlatforms)GetChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMPLATFORMS);
		}
		set
		{
			RemoveChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMPLATFORMS);
			if( value != null)
			{
				AddChild( AssessmentDTD.SIF3ASSESSMENTITEM_ASSESSMENTITEMPLATFORMS, value );
			}
		}
	}

}}
