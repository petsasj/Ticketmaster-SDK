﻿namespace Ticketmaster.Discovery.V2.Models
{
    using Core;

    public class SearchEventsRequest : BaseQuery<SearchEventsRequest, SearchEventsQueryParameters>
    {
        public override SearchEventsRequest AddQueryParameter(SearchEventsQueryParameters parameter, string value)
        {
            Parameters.Add(parameter.ToString(), value);
            return this;
        }
    }
}