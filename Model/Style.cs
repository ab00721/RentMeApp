namespace RentMeApp.Model
{
    /// <summary>
    /// Style DTO class
    /// </summary>
    public class Style
    {
        public string StyleName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Style"/> class.
        /// </summary>
        /// <param name="styleName">The name of the style.</param>
        public Style(string styleName)
        {
            StyleName = styleName;
        }
    }
}
