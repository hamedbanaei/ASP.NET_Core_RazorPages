namespace Server.Pages
{
	public class Learn009Model :
		Microsoft.AspNetCore.Mvc.RazorPages.PageModel
	{
		public Learn009Model() : base()
		{
			//SomePublicField = "Initial Value";
		}

		//public string SomePublicField;

		// Class Members Access Modifier Types:
		// Public Access Modifier: Objects that implement public access modifiers are accessible from everywhere in our project. Therefore, there are no accessibility restrictions.
		// Private Access Modifier: Objects that implement private access modifiers are accessible only inside a class or a structure. As a result, we can’t access them outside the class they are created.
		// Protected Access Modifier: The protected keyword implies that the object is accessible inside the class and in all classes that derive from that class.
		// Internal Access Modifier: The internal keyword specifies that the object is accessible only inside its own assembly but not in other assemblies.
		// Protected Internal Access Modifier: The protected internal access modifier is a combination of protected and internal. As a result, we can access the protected internal member only in the same assembly or in a derived class in other assemblies.
		// Private Protected Access Modifier: The private protected access modifier is a combination of private and protected keywords. We can access members inside the containing class or in a class that derives from a containing class, but only in the same assembly(project). Therefore, if we try to access it from another assembly, we will get an error.

		// See this link for further information.
		// https://code-maze.com/csharp-access-modifiers

		// **********
		/// <summary>
		/// OK
		/// </summary>
		public string? PublicField;

		private string? _privateField;

		protected string? ProtectedField;

		/// <summary>
		/// OK
		/// </summary>
		internal string? InternalField;

		/// <summary>
		/// OK
		/// </summary>
		protected internal string? ProtectedInternalField;

		private protected string? PrivateProtectedField;
		// **********

		// **********
		/// <summary>
		/// OK
		/// </summary>
		public string? PublicProperty { get; set; }

		private string? PrivateProperty { get; set; }

		protected string? ProtectedProperty { get; set; }

		/// <summary>
		/// OK
		/// </summary>
		internal string? InternalProperty { get; set; }

		/// <summary>
		/// OK
		/// </summary>
		protected internal string? ProtectedInternalProperty { get; set; }

		private protected string? PrivateProtectedProperty { get; set; }
		// **********

		public void OnGet()
		{
			// **************************************************
			PublicField = "Public Field";
			_privateField = "Private Field";
			ProtectedField = "Protected Field";
			InternalField = "Internal Field";
			ProtectedInternalField = "Protected Internal Field";
			PrivateProtectedField = "Private Protected Field";
			// **************************************************

			// **************************************************
			PublicProperty = "Public Property";
			PrivateProperty = "Private Property";
			ProtectedProperty = "Protected Property";
			InternalProperty = "Internal Property";
			ProtectedInternalProperty = "Protected Internal Property";
			PrivateProtectedProperty = "Private Protected Property";
			// **************************************************
		}
	}
}
