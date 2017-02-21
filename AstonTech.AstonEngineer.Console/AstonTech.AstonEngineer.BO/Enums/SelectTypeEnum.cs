
namespace AstonTech.AstonEngineer
{
    /// <summary>
    /// Values correspond to the @QueryId in the SELECT (dbo.usp_GetXXX) stored procedures
    /// The integer value needs to b e passed to the procedures from the DAL.
    /// </summary>
    public enum SelectTypeEnum
    {
        /// <summary>
        /// Defaults to none
        /// </summary>
        None = 0,
        /// <summary>
        /// Gets a single item from the database
        /// </summary>
        GetItem = 10,
        /// <summary>
        /// Gets a collection of items from the database
        /// </summary>
        GetCollection = 20
    }
}
