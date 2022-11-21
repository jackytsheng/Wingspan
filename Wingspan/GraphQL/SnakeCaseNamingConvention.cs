﻿using System;
using System.Text;
using HotChocolate.Types.Descriptors;

namespace Wingspan.GraphQL;

public class SnakeCaseNamingConvention : DefaultNamingConventions
{
    public string ToSnakeCase(string text)
    {
        if (text == null)
        {
            throw new ArgumentNullException(nameof(text));
        }

        if (text.Length < 2)
        {
            return text;
        }

        var sb = new StringBuilder();
        sb.Append(char.ToLowerInvariant(text[0]));
        for (int i = 1; i < text.Length; ++i)
        {
            char c = text[i];
            if (char.IsUpper(c))
            {
                sb.Append('_');
                sb.Append(char.ToLowerInvariant(c));
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    public override string GetEnumValueName(object value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        return ToSnakeCase(value.ToString()); // change this to whatever you like
    }
}
