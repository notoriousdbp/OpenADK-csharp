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

namespace OpenADK.Library.us.Student{

/// <summary>A ContactFlags</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class ContactFlags : SifElement
{
	/// <summary>
	/// Creates an instance of a ContactFlags
	/// </summary>
	public ContactFlags() : base ( StudentDTD.CONTACTFLAGS ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ContactFlags( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;PickupRights&gt;</c> element.
	/// </summary>
	/// <value> The <c>PickupRights</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This element tells whether or not the contact has pickup rights."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string PickupRights
	{
		get
		{ 
			return GetFieldValue( StudentDTD.CONTACTFLAGS_PICKUPRIGHTS );
		}
		set
		{
			SetField( StudentDTD.CONTACTFLAGS_PICKUPRIGHTS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;PickupRights&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This element tells whether or not the contact has pickup rights."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetPickupRights( YesNoUnknown val )
	{
		SetField( StudentDTD.CONTACTFLAGS_PICKUPRIGHTS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ParentLegalGuardian&gt;</c> element.
	/// </summary>
	/// <value> The <c>ParentLegalGuardian</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the individual have parental or legal guardianship responsibility for the student?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string ParentLegalGuardian
	{
		get
		{ 
			return GetFieldValue( StudentDTD.CONTACTFLAGS_PARENTLEGALGUARDIAN );
		}
		set
		{
			SetField( StudentDTD.CONTACTFLAGS_PARENTLEGALGUARDIAN, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;ParentLegalGuardian&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the individual have parental or legal guardianship responsibility for the student?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetParentLegalGuardian( YesNoUnknown val )
	{
		SetField( StudentDTD.CONTACTFLAGS_PARENTLEGALGUARDIAN, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LivesWith&gt;</c> element.
	/// </summary>
	/// <value> The <c>LivesWith</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student live with this contact?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LivesWith
	{
		get
		{ 
			return GetFieldValue( StudentDTD.CONTACTFLAGS_LIVESWITH );
		}
		set
		{
			SetField( StudentDTD.CONTACTFLAGS_LIVESWITH, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;LivesWith&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the student live with this contact?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetLivesWith( YesNoUnknown val )
	{
		SetField( StudentDTD.CONTACTFLAGS_LIVESWITH, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AccessToRecords&gt;</c> element.
	/// </summary>
	/// <value> The <c>AccessToRecords</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does this contact have access to the student's records?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AccessToRecords
	{
		get
		{ 
			return GetFieldValue( StudentDTD.CONTACTFLAGS_ACCESSTORECORDS );
		}
		set
		{
			SetField( StudentDTD.CONTACTFLAGS_ACCESSTORECORDS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AccessToRecords&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does this contact have access to the student's records?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetAccessToRecords( YesNoUnknown val )
	{
		SetField( StudentDTD.CONTACTFLAGS_ACCESSTORECORDS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EmergencyContact&gt;</c> element.
	/// </summary>
	/// <value> The <c>EmergencyContact</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Should this contact be notified in case of emergency?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string EmergencyContact
	{
		get
		{ 
			return GetFieldValue( StudentDTD.CONTACTFLAGS_EMERGENCYCONTACT );
		}
		set
		{
			SetField( StudentDTD.CONTACTFLAGS_EMERGENCYCONTACT, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;EmergencyContact&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Should this contact be notified in case of emergency?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetEmergencyContact( YesNoUnknown val )
	{
		SetField( StudentDTD.CONTACTFLAGS_EMERGENCYCONTACT, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;HasCustody&gt;</c> element.
	/// </summary>
	/// <value> The <c>HasCustody</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does this contact have or share custody of the student?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string HasCustody
	{
		get
		{ 
			return GetFieldValue( StudentDTD.CONTACTFLAGS_HASCUSTODY );
		}
		set
		{
			SetField( StudentDTD.CONTACTFLAGS_HASCUSTODY, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;HasCustody&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does this contact have or share custody of the student?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetHasCustody( YesNoUnknown val )
	{
		SetField( StudentDTD.CONTACTFLAGS_HASCUSTODY, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DisciplinaryContact&gt;</c> element.
	/// </summary>
	/// <value> The <c>DisciplinaryContact</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is this person to be contacted in case of disciplinary action?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string DisciplinaryContact
	{
		get
		{ 
			return GetFieldValue( StudentDTD.CONTACTFLAGS_DISCIPLINARYCONTACT );
		}
		set
		{
			SetField( StudentDTD.CONTACTFLAGS_DISCIPLINARYCONTACT, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;DisciplinaryContact&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is this person to be contacted in case of disciplinary action?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetDisciplinaryContact( YesNoUnknown val )
	{
		SetField( StudentDTD.CONTACTFLAGS_DISCIPLINARYCONTACT, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PrimaryCareProvider&gt;</c> element.
	/// </summary>
	/// <value> The <c>PrimaryCareProvider</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does this person provide daily living or personal assistance to the student?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string PrimaryCareProvider
	{
		get
		{ 
			return GetFieldValue( StudentDTD.CONTACTFLAGS_PRIMARYCAREPROVIDER );
		}
		set
		{
			SetField( StudentDTD.CONTACTFLAGS_PRIMARYCAREPROVIDER, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;PrimaryCareProvider&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does this person provide daily living or personal assistance to the student?"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetPrimaryCareProvider( YesNoUnknown val )
	{
		SetField( StudentDTD.CONTACTFLAGS_PRIMARYCAREPROVIDER, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Other&gt;</c> element.
	/// </summary>
	/// <value> The <c>Other</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This person has a relationship to student(s) that the school needs to document but no other contact flag value is 'Yes'. An example is a parent who enrolled the student but is deceased and is no longer a valid contact"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Other
	{
		get
		{ 
			return GetFieldValue( StudentDTD.CONTACTFLAGS_OTHER );
		}
		set
		{
			SetField( StudentDTD.CONTACTFLAGS_OTHER, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Other&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNoUnknown object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This person has a relationship to student(s) that the school needs to document but no other contact flag value is 'Yes'. An example is a parent who enrolled the student but is deceased and is no longer a valid contact"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetOther( YesNoUnknown val )
	{
		SetField( StudentDTD.CONTACTFLAGS_OTHER, val );
	}

}}
