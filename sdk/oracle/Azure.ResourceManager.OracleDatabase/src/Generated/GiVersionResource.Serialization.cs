// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.OracleDatabase
{
    public partial class GiVersionResource : IJsonModel<GiVersionData>
    {
        void IJsonModel<GiVersionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GiVersionData>)Data).Write(writer, options);

        GiVersionData IJsonModel<GiVersionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GiVersionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<GiVersionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        GiVersionData IPersistableModel<GiVersionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GiVersionData>(data, options);

        string IPersistableModel<GiVersionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GiVersionData>)Data).GetFormatFromOptions(options);
    }
}
