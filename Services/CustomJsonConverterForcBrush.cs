using c.Configuration;
using c.Configuration.Stringing;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestProject.Services
{
    public class CustomJsonConverterForcBrush : JsonConverter<cBrush>
    {
        public override cBrush Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
            )
        {
            // Caution: Deserialization of type instances like this 
            // is not recommended and should be avoided
            // since it can lead to potential security issues.

            // If you really want this supported (for instance if the JSON input is trusted):
            // string assemblyQualifiedName = reader.GetString();
            // return Type.GetType(assemblyQualifiedName);
            throw new NotSupportedException();
        }

        public override void Write(
            Utf8JsonWriter writer,
            cBrush value,
            JsonSerializerOptions options
            )
        {
            string assemblyQualifiedName = value.SaveToString();
            //// Use this with caution, since you are disclosing type information.
            writer.WriteStringValue(assemblyQualifiedName);
        }
    }
}
