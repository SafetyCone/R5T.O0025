using System;

using R5T.T0131;


namespace R5T.O0025
{
    [ValuesMarker]
    public partial interface IProjectElementOperations : IValuesMarker,
        O000.IProjectElementOperations,
        O001.IProjectElementOperations,
        O002.IProjectElementOperations,
        O003.IProjectElementOperations
    {

    }
}
