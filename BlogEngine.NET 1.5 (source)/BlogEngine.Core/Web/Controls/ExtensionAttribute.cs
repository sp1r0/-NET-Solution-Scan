using System;

namespace BlogEngine.Core.Web.Controls
{
  /// <summary>
  /// All extensions must decorate the class with this attribute.
  /// It is used for reflection.
  /// <remarks>
  /// When using this attribute, you must make sure
  /// to have a default constructor. It will be used to create
  /// an instance of the extension through reflection.
  /// </remarks>
  /// </summary>
  [AttributeUsage(AttributeTargets.Class)]
  public sealed class ExtensionAttribute : System.Attribute
  {
    /// <summary>
    /// Creates an instance of the attribute and assigns a description.
    /// </summary>
    public ExtensionAttribute(string description, string version, string author)
    {
      _Description = description;
      _Version = version;
      _Author = author;
    }

    /// <summary>
    /// Creates an instance of the attribute and assigns a description.
    /// </summary>
    public ExtensionAttribute(string description, string version, string author, int priority)
    {
        _Description = description;
        _Version = version;
        _Author = author;
        _priority = priority;
    }

    private string _Description;
    /// <summary>
    /// Gets the description of the extension.
    /// </summary>
    public string Description
    {
      get { return _Description; }
    }

    private string _Version;

    /// <summary>
    /// Gets the version number of the extension
    /// </summary>
    public string Version
    {
      get { return _Version; }
    }

    private string _Author;

    /// <summary>
    /// Gets the author of the extension
    /// </summary>
    public string Author
    {
      get { return _Author; }
    }

    private int _priority = 999;

    /// <summary>
    /// Gets the priority of the extension
    /// This determins in what order extensions instantiated
    /// and in what order they will respond to events
    /// </summary>
    public int Priority
    {
        get { return _priority; }
    }

  }

  /// <summary>
  /// Helper class for sorting extensions by priority
  /// </summary>
  public class SortedExtension
  {
      public int Priority;
      public string Name;
      public string Type;

      public SortedExtension(int p, string n, string t)
      {
          Priority = p;
          Name = n;
          Type = t;
      }
  }    

}