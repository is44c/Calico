﻿
namespace Graphviz4Net.Dot.AntlrParser
{
    using System.Collections.Generic;

    public class StringDotGraphBuilder : DotGraphBuilder<string>
    {
        private readonly IDictionary<string, DotVertex<string>> vertices = 
            new Dictionary<string, DotVertex<string>>();

        public StringDotGraphBuilder()
        {
            this.DotGraph = new DotGraph<string>();
        }

        protected override DotVertex<string> CreateVertex(string idStr, IDictionary<string, string> attributes)
        {
            var result = new DotVertex<string>(idStr, attributes);
            this.vertices.Add(idStr, result);
            return result;
        }

        protected override DotVertex<string> GetVertex(string idStr)
        {
            DotVertex<string> result;
			if (idStr.Contains(":")) {
				string [] parts = idStr.Split(':');
				idStr = parts[0];
			}
            if (this.vertices.TryGetValue(idStr, out result))
            {
                return result;
            }

            var msg = string.Format("The vertex with id {0} was used before it was defined.", idStr);
            throw new ParserException(msg);
        }
    }
}
