using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcSiteMapProvider.Extensibility;

namespace Catalog.Helpers
{
    public class VineDynamicNodeProvider : DynamicNodeProviderBase
    {
        List<string> IDs = new List<string>();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection()
        {
            var nodes = new List<DynamicNode>();
            IDs.Add("1");
            IDs.Add("2");
            IDs.Add("3");
            foreach (var id in IDs)
            {
                DynamicNode node = new DynamicNode();
                node.RouteValues.Add("id", id);
                node.Title = node.Title + id;
                nodes.Add(node);
            }

            return nodes;
        }
    }
}