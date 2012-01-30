﻿
namespace Graphviz4Net
{
    using System.Collections.Generic;
    using System.Windows;
    using Dot;
    using Graphs;

    /// <summary>
    /// An interface for a class that builds the actual layout from information 
    /// provided by the <see cref="LayoutDirector"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The <see cref="LayoutDirector"/> object directs the whole process of creating 
    /// the layout, when it has a piece of information about, e.g., a vertex position 
    /// and size, it passes this piece of information to the builder, so the builder can 
    /// create an actual vertex in the WPF Canvas, Windows Form, HTML/CSS files, ...
    /// </para>
    /// <para>
    /// The director gets an <c>original <see cref="IGraph"/></c> from the user, 
    /// then it uses dot to create a layout for it -- this results into a new 
    /// instance of the original graph, we will call it <c>dot graph</c>, 
    /// that contains layout information. Most of the builder methods has an 
    /// original graph element and then the dot graph element 
    /// among their parameters.
    /// </para>
    /// <para>
    /// Values generated by dot are passed to <see cref="ILayoutBuilder"/> as they are. 
    /// So the conversion must be done by the builder (each build will probably perform 
    /// different kind of conversion). Dot used 2 axes X and Y. Position [0,0] is in 
    /// the top, left corner and it increases to the right and to the bottom. 
    /// Sizes (width, height) should be multiplied by 72 to have the same measure as positions.
    /// </para>
    /// </remarks>
    public interface ILayoutBuilder
    {
        /// <summary>
        /// Starts the process of building a layout for the <paramref name="originalGraph"/>. 
        /// </summary>
        /// <param name="originalGraph">The original graph that should be laid out.</param>
        void Start(IGraph originalGraph);

        /// <summary>
        /// Can be used to set up the size of a drawing area.
        /// </summary>
        /// <param name="width">The with of the generated layout.</param>
        /// <param name="height">The height of the generated layout.</param>
        /// <param name="originalGraph">The original graph to be drawn.</param>
        /// <param name="dotGraph">The according generated dot graph with the layout information.</param>
        void BuildGraph(double width, double height, IGraph originalGraph, DotGraph dotGraph);

        /// <summary>
        /// Builds a vertex provided with it's position and size, but also with the instance of the 
        /// vertex in the original graph and instance of the vertex in graph generated by dot. 
        /// (the position and size should be enough for most of layout builders)
        /// </summary>
        /// <param name="position">The position of the vertex. 
        /// Dot uses position coordinates incrementing from the top left corner.</param>
        /// <param name="width">The width of the vertex. 
        /// Multiply this value by 72 to get the same measure as for <paramref name="position"/>.</param>
        /// <param name="height">The height of the vertex. 
        /// Multiply this value by 72 to get the same measure as for <paramref name="position"/>.</param>
        /// <param name="originalVertex">The vertex from original graph that is to be drawn.</param>
        /// <param name="dotVertex">The according vertex with layout information generated by dot.</param>
        void BuildVertex(Point position, double width, double height, object originalVertex, DotVertex dotVertex);

        /// <summary>
        /// Builds a subgraph area provided with it's positions.
        /// </summary>
        /// <param name="originalSubGraph">The subgraph from the original graph that is to be drawn.</param>
        /// <param name="subGraph">The according subgraph with layout information generated by dot.</param>
        void BuildSubGraph(
            double leftX, 
            double upperY, 
            double rightX, 
            double lowerY, 
            ISubGraph originalSubGraph, 
            DotSubGraph subGraph);

        /// <summary>
        /// Builds an edge provided with it's path. 
        /// The path format is basically similar to the one used by WPF.
        /// See a dot manual for more detailed explanation.
        /// </summary>
        /// <remarks>
        /// Only a path of the edge is provided as a separate parameter, but the 
        /// <paramref name="edge"/> contains more layout information such as label 
        /// position, or arrows positions. It depends upon the author of the builder 
        /// whether he/she wants to support all these scenarios.
        /// </remarks>
        void BuildEdge(Point[] path, IEdge originalEdge, DotEdge edge);

        /// <summary>
        /// The last method called by <see cref="LayoutDirector"/> when everything is done.
        /// </summary>
        void Finish();

        /// <summary>
        /// Provides an expected size of given vertex so the dot knows how to layout this vertex. 
        /// The size is measured as 1/72 of a point used for positions measure. (Just multiply it by 1/72)
        /// </summary>
        /// <param name="vertex">The original vertex which should be measured.</param>
        /// <returns></returns>
        Size GetSize(object vertex);

        /// <summary>
        /// Provides a way to add more attributes into the input file for dot, 
        /// so the layouting process can be tweaked.
        /// </summary>
        IEnumerable<KeyValuePair<string, string>> GetAdditionalAttributes(object vertex);
    }
}