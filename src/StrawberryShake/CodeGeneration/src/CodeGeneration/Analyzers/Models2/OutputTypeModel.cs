using System;
using System.Collections.Generic;
using HotChocolate.Language;
using HotChocolate.Types;

namespace StrawberryShake.CodeGeneration.Analyzers.Models2
{
    public sealed class OutputTypeModel : ITypeModel
    {
        public OutputTypeModel(
            string name,
            string? description,
            bool isInterface,
            INamedType type,
            SelectionSetNode selectionSet,
            IReadOnlyList<OutputFieldModel> fields,
            IReadOnlyList<OutputTypeModel>? implementations = null)
        {
            Name = name;
            Description = description;
            IsInterface = isInterface;
            Type = type;
            SelectionSet = selectionSet;
            Fields = fields;
            Implementations = implementations ?? Array.Empty<OutputTypeModel>();
        }

        public string Name { get; }

        public string? Description { get; }

        public bool IsInterface { get; }

        public INamedType Type { get; }

        public SelectionSetNode SelectionSet { get; }

        public IReadOnlyList<OutputTypeModel> Implementations { get; }

        public IReadOnlyList<OutputFieldModel> Fields { get; }
    }
}
