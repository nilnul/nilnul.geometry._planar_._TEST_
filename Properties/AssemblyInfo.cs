using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;



///deps
///
/// img is now subsequent to this.
/// the dep of img:
///		geometry.planar
///			which defines graphics, but not color.
///			img adds color to graphics.
///	,may be removed such that geometry would dependent on img so drawing there would be at hand.
///		,to maitain the compatibility, keep this prj, and make a new prj named:
///			pic?  meaning pixel
///				pix
///			fig?
///		, to represent the physical device such as paper or screen to show an image.


// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("nilnul.geometry._planar_._TEST_")]
[assembly: AssemblyDescription("nilnul.geometry._planar_._TEST_")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("nilnul.com")]
[assembly: AssemblyProduct("nilnul.geometry._planar_._TEST_")]
[assembly: AssemblyCopyright("wangyoutian@nilnul.com")]
[assembly: AssemblyTrademark("nilnul.geometry._planar_._TEST_")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("91901677-194c-419d-8400-7b557dc711a3")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
