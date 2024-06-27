﻿using Microsoft.AspNetCore.Components;

namespace TabBlazor
{
    public class DetailsRowBase<TableItem> : ComponentBase // ComponentBase
    {
        [Parameter] public IDetailsTable<TableItem> Table { get; set; }
        [Parameter] public TableItem Item { get; set; }
    }
}