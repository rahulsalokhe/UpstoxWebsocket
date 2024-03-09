//#RahulSalokhe
//RahulSalokhe@gmail.com
#pragma warning disable 1591, 0612, 3021, 8981

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;

namespace UpstoxWebsocket;


public static partial class MarketDataFeed
{

    #region Descriptor

    public static pbr::FileDescriptor Descriptor
    {
        get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MarketDataFeed()
    {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            string.Concat(
              "ChRNYXJrZXREYXRhRmVlZC5wcm90bxImY29tLnVwc3RveC5tYXJrZXRkYXRh",
              "ZmVlZGVyLnJwYy5wcm90bzEiOQoETFRQQxILCgNsdHAYASABKAESCwoDbHR0",
              "GAIgASgDEgsKA2x0cRgDIAEoAxIKCgJjcBgEIAEoASJRCgtNYXJrZXRMZXZl",
              "bBJCCgtiaWRBc2tRdW90ZRgBIAMoCzItLmNvbS51cHN0b3gubWFya2V0ZGF0",
              "YWZlZWRlci5ycGMucHJvdG8xLlF1b3RlIkgKCk1hcmtldE9ITEMSOgoEb2hs",
              "YxgBIAMoCzIsLmNvbS51cHN0b3gubWFya2V0ZGF0YWZlZWRlci5ycGMucHJv",
              "dG8xLk9ITEMiUQoFUXVvdGUSCgoCYnEYASABKAUSCgoCYnAYAiABKAESCwoD",
              "Ym5vGAMgASgFEgoKAmFxGAQgASgFEgoKAmFwGAUgASgBEgsKA2FubxgGIAEo",
              "BSJ6CgxPcHRpb25HcmVla3MSCgoCb3AYASABKAESCgoCdXAYAiABKAESCgoC",
              "aXYYAyABKAESDQoFZGVsdGEYBCABKAESDQoFdGhldGEYBSABKAESDQoFZ2Ft",
              "bWEYBiABKAESDAoEdmVnYRgHIAEoARILCgNyaG8YCCABKAEivwIKE0V4dGVu",
              "ZGVkRmVlZERldGFpbHMSCwoDYXRwGAEgASgBEgoKAmNwGAIgASgBEgsKA3Z0",
              "dBgDIAEoAxIKCgJvaRgEIAEoARIQCghjaGFuZ2VPaRgFIAEoARIRCglsYXN0",
              "Q2xvc2UYBiABKAESCwoDdGJxGAcgASgBEgsKA3RzcRgIIAEoARINCgVjbG9z",
              "ZRgJIAEoARIKCgJsYxgKIAEoARIKCgJ1YxgLIAEoARIKCgJ5aBgMIAEoARIK",
              "CgJ5bBgNIAEoARIKCgJmcBgOIAEoARIKCgJmdhgPIAEoBRIOCgZtYnBCdXkY",
              "ECABKAMSDwoHbWJwU2VsbBgRIAEoAxIKCgJ0dhgSIAEoAxIMCgRkaG9pGBMg",
              "ASgBEgwKBGRsb2kYFCABKAESCgoCc3AYFSABKAESCwoDcG9pGBYgASgBImwK",
              "BE9ITEMSEAoIaW50ZXJ2YWwYASABKAkSDAoEb3BlbhgCIAEoARIMCgRoaWdo",
              "GAMgASgBEgsKA2xvdxgEIAEoARINCgVjbG9zZRgFIAEoARIOCgZ2b2x1bWUY",
              "BiABKAUSCgoCdHMYByABKAMi/QIKDk1hcmtldEZ1bGxGZWVkEjoKBGx0cGMY",
              "ASABKAsyLC5jb20udXBzdG94Lm1hcmtldGRhdGFmZWVkZXIucnBjLnByb3Rv",
              "MS5MVFBDEkgKC21hcmtldExldmVsGAIgASgLMjMuY29tLnVwc3RveC5tYXJr",
              "ZXRkYXRhZmVlZGVyLnJwYy5wcm90bzEuTWFya2V0TGV2ZWwSSgoMb3B0aW9u",
              "R3JlZWtzGAMgASgLMjQuY29tLnVwc3RveC5tYXJrZXRkYXRhZmVlZGVyLnJw",
              "Yy5wcm90bzEuT3B0aW9uR3JlZWtzEkYKCm1hcmtldE9ITEMYBCABKAsyMi5j",
              "b20udXBzdG94Lm1hcmtldGRhdGFmZWVkZXIucnBjLnByb3RvMS5NYXJrZXRP",
              "SExDElEKDGVGZWVkRGV0YWlscxgFIAEoCzI7LmNvbS51cHN0b3gubWFya2V0",
              "ZGF0YWZlZWRlci5ycGMucHJvdG8xLkV4dGVuZGVkRmVlZERldGFpbHMivgEK",
              "DUluZGV4RnVsbEZlZWQSOgoEbHRwYxgBIAEoCzIsLmNvbS51cHN0b3gubWFy",
              "a2V0ZGF0YWZlZWRlci5ycGMucHJvdG8xLkxUUEMSRgoKbWFya2V0T0hMQxgC",
              "IAEoCzIyLmNvbS51cHN0b3gubWFya2V0ZGF0YWZlZWRlci5ycGMucHJvdG8x",
              "Lk1hcmtldE9ITEMSEQoJbGFzdENsb3NlGAMgASgBEgoKAnloGAQgASgBEgoK",
              "AnlsGAUgASgBIrEBCghGdWxsRmVlZBJKCghtYXJrZXRGRhgBIAEoCzI2LmNv",
              "bS51cHN0b3gubWFya2V0ZGF0YWZlZWRlci5ycGMucHJvdG8xLk1hcmtldEZ1",
              "bGxGZWVkSAASSAoHaW5kZXhGRhgCIAEoCzI1LmNvbS51cHN0b3gubWFya2V0",
              "ZGF0YWZlZWRlci5ycGMucHJvdG8xLkluZGV4RnVsbEZlZWRIAEIPCg1GdWxs",
              "RmVlZFVuaW9uIqwCCgtPcHRpb25DaGFpbhI6CgRsdHBjGAEgASgLMiwuY29t",
              "LnVwc3RveC5tYXJrZXRkYXRhZmVlZGVyLnJwYy5wcm90bzEuTFRQQxJCCgti",
              "aWRBc2tRdW90ZRgCIAEoCzItLmNvbS51cHN0b3gubWFya2V0ZGF0YWZlZWRl",
              "ci5ycGMucHJvdG8xLlF1b3RlEkoKDG9wdGlvbkdyZWVrcxgDIAEoCzI0LmNv",
              "bS51cHN0b3gubWFya2V0ZGF0YWZlZWRlci5ycGMucHJvdG8xLk9wdGlvbkdy",
              "ZWVrcxJRCgxlRmVlZERldGFpbHMYBCABKAsyOy5jb20udXBzdG94Lm1hcmtl",
              "dGRhdGFmZWVkZXIucnBjLnByb3RvMS5FeHRlbmRlZEZlZWREZXRhaWxzItQB",
              "CgRGZWVkEjwKBGx0cGMYASABKAsyLC5jb20udXBzdG94Lm1hcmtldGRhdGFm",
              "ZWVkZXIucnBjLnByb3RvMS5MVFBDSAASPgoCZmYYAiABKAsyMC5jb20udXBz",
              "dG94Lm1hcmtldGRhdGFmZWVkZXIucnBjLnByb3RvMS5GdWxsRmVlZEgAEkEK",
              "Am9jGAMgASgLMjMuY29tLnVwc3RveC5tYXJrZXRkYXRhZmVlZGVyLnJwYy5w",
              "cm90bzEuT3B0aW9uQ2hhaW5IAEILCglGZWVkVW5pb24i9gEKDEZlZWRSZXNw",
              "b25zZRI6CgR0eXBlGAEgASgOMiwuY29tLnVwc3RveC5tYXJrZXRkYXRhZmVl",
              "ZGVyLnJwYy5wcm90bzEuVHlwZRJOCgVmZWVkcxgCIAMoCzI/LmNvbS51cHN0",
              "b3gubWFya2V0ZGF0YWZlZWRlci5ycGMucHJvdG8xLkZlZWRSZXNwb25zZS5G",
              "ZWVkc0VudHJ5GloKCkZlZWRzRW50cnkSCwoDa2V5GAEgASgJEjsKBXZhbHVl",
              "GAIgASgLMiwuY29tLnVwc3RveC5tYXJrZXRkYXRhZmVlZGVyLnJwYy5wcm90",
              "bzEuRmVlZDoCOAEqJwoEVHlwZRIQCgxpbml0aWFsX2ZlZWQQABINCglsaXZl",
              "X2ZlZWQQAUIZqgIWVXBzdG94TWFya2V0RGF0YUZlZWRlcmIGcHJvdG8z"));
        descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
            new pbr::FileDescriptor[] { },
            new pbr::GeneratedClrTypeInfo(new[] { typeof(global::UpstoxWebsocket.Type), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.LTPC), global::UpstoxWebsocket.LTPC.Parser, new[]{ "Ltp", "Ltt", "Ltq", "Cp" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.MarketLevel), global::UpstoxWebsocket.MarketLevel.Parser, new[]{ "BidAskQuote" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.MarketOHLC), global::UpstoxWebsocket.MarketOHLC.Parser, new[]{ "Ohlc" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.Quote), global::UpstoxWebsocket.Quote.Parser, new[]{ "Bq", "Bp", "Bno", "Aq", "Ap", "Ano" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.OptionGreeks), global::UpstoxWebsocket.OptionGreeks.Parser, new[]{ "Op", "Up", "Iv", "Delta", "Theta", "Gamma", "Vega", "Rho" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.ExtendedFeedDetails), global::UpstoxWebsocket.ExtendedFeedDetails.Parser, new[]{ "Atp", "Cp", "Vtt", "Oi", "ChangeOi", "LastClose", "Tbq", "Tsq", "Close", "Lc", "Uc", "Yh", "Yl", "Fp", "Fv", "MbpBuy", "MbpSell", "Tv", "Dhoi", "Dloi", "Sp", "Poi" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.OHLC), global::UpstoxWebsocket.OHLC.Parser, new[]{ "Interval", "Open", "High", "Low", "Close", "Volume", "Ts" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.MarketFullFeed), global::UpstoxWebsocket.MarketFullFeed.Parser, new[]{ "Ltpc", "MarketLevel", "OptionGreeks", "MarketOHLC", "EFeedDetails" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.IndexFullFeed), global::UpstoxWebsocket.IndexFullFeed.Parser, new[]{ "Ltpc", "MarketOHLC", "LastClose", "Yh", "Yl" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.FullFeed), global::UpstoxWebsocket.FullFeed.Parser, new[]{ "MarketFF", "IndexFF" }, new[]{ "FullFeedUnion" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.OptionChain), global::UpstoxWebsocket.OptionChain.Parser, new[]{ "Ltpc", "BidAskQuote", "OptionGreeks", "EFeedDetails" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.Feed), global::UpstoxWebsocket.Feed.Parser, new[]{ "Ltpc", "Ff", "Oc" }, new[]{ "FeedUnion" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UpstoxWebsocket.FeedResponse), global::UpstoxWebsocket.FeedResponse.Parser, new[]{ "Type", "Feeds" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
            }));
    }
    #endregion

}
#region Enums
public enum Type
{
    [pbr::OriginalName("initial_feed")] InitialFeed = 0,
    [pbr::OriginalName("live_feed")] LiveFeed = 1,
}

#endregion

#region Messages
[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class LTPC : pb::IMessage<LTPC>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<LTPC> _parser = new pb::MessageParser<LTPC>(() => new LTPC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LTPC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LTPC()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LTPC(LTPC other) : this()
    {
        ltp_ = other.ltp_;
        ltt_ = other.ltt_;
        ltq_ = other.ltq_;
        cp_ = other.cp_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LTPC Clone()
    {
        return new LTPC(this);
    }

    /// <summary>Field number for the "ltp" field.</summary>
    public const int LtpFieldNumber = 1;
    private double ltp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Ltp
    {
        get { return ltp_; }
        set
        {
            ltp_ = value;
        }
    }

    /// <summary>Field number for the "ltt" field.</summary>
    public const int LttFieldNumber = 2;
    private long ltt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Ltt
    {
        get { return ltt_; }
        set
        {
            ltt_ = value;
        }
    }

    /// <summary>Field number for the "ltq" field.</summary>
    public const int LtqFieldNumber = 3;
    private long ltq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Ltq
    {
        get { return ltq_; }
        set
        {
            ltq_ = value;
        }
    }

    /// <summary>Field number for the "cp" field.</summary>
    public const int CpFieldNumber = 4;
    private double cp_;
    /// <summary>
    ///close price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Cp
    {
        get { return cp_; }
        set
        {
            cp_ = value;
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as LTPC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LTPC other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Ltp, other.Ltp)) return false;
        if (Ltt != other.Ltt) return false;
        if (Ltq != other.Ltq) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Cp, other.Cp)) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (Ltp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Ltp);
        if (Ltt != 0L) hash ^= Ltt.GetHashCode();
        if (Ltq != 0L) hash ^= Ltq.GetHashCode();
        if (Cp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Cp);
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (Ltp != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Ltp);
      }
      if (Ltt != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Ltt);
      }
      if (Ltq != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Ltq);
      }
      if (Cp != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Cp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (Ltp != 0D)
        {
            output.WriteRawTag(9);
            output.WriteDouble(Ltp);
        }
        if (Ltt != 0L)
        {
            output.WriteRawTag(16);
            output.WriteInt64(Ltt);
        }
        if (Ltq != 0L)
        {
            output.WriteRawTag(24);
            output.WriteInt64(Ltq);
        }
        if (Cp != 0D)
        {
            output.WriteRawTag(33);
            output.WriteDouble(Cp);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (Ltp != 0D)
        {
            size += 1 + 8;
        }
        if (Ltt != 0L)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Ltt);
        }
        if (Ltq != 0L)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Ltq);
        }
        if (Cp != 0D)
        {
            size += 1 + 8;
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LTPC other)
    {
        if (other == null)
        {
            return;
        }
        if (other.Ltp != 0D)
        {
            Ltp = other.Ltp;
        }
        if (other.Ltt != 0L)
        {
            Ltt = other.Ltt;
        }
        if (other.Ltq != 0L)
        {
            Ltq = other.Ltq;
        }
        if (other.Cp != 0D)
        {
            Cp = other.Cp;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            Ltp = input.ReadDouble();
            break;
          }
          case 16: {
            Ltt = input.ReadInt64();
            break;
          }
          case 24: {
            Ltq = input.ReadInt64();
            break;
          }
          case 33: {
            Cp = input.ReadDouble();
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 9:
                    {
                        Ltp = input.ReadDouble();
                        break;
                    }
                case 16:
                    {
                        Ltt = input.ReadInt64();
                        break;
                    }
                case 24:
                    {
                        Ltq = input.ReadInt64();
                        break;
                    }
                case 33:
                    {
                        Cp = input.ReadDouble();
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class MarketLevel : pb::IMessage<MarketLevel>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<MarketLevel> _parser = new pb::MessageParser<MarketLevel>(() => new MarketLevel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MarketLevel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarketLevel()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarketLevel(MarketLevel other) : this()
    {
        bidAskQuote_ = other.bidAskQuote_.Clone();
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarketLevel Clone()
    {
        return new MarketLevel(this);
    }

    /// <summary>Field number for the "bidAskQuote" field.</summary>
    public const int BidAskQuoteFieldNumber = 1;
    private static readonly pb::FieldCodec<global::UpstoxWebsocket.Quote> _repeated_bidAskQuote_codec
        = pb::FieldCodec.ForMessage(10, global::UpstoxWebsocket.Quote.Parser);
    private readonly pbc::RepeatedField<global::UpstoxWebsocket.Quote> bidAskQuote_ = new pbc::RepeatedField<global::UpstoxWebsocket.Quote>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::UpstoxWebsocket.Quote> BidAskQuote
    {
        get { return bidAskQuote_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as MarketLevel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MarketLevel other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!bidAskQuote_.Equals(other.bidAskQuote_)) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        hash ^= bidAskQuote_.GetHashCode();
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      bidAskQuote_.WriteTo(output, _repeated_bidAskQuote_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        bidAskQuote_.WriteTo(ref output, _repeated_bidAskQuote_codec);
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        size += bidAskQuote_.CalculateSize(_repeated_bidAskQuote_codec);
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MarketLevel other)
    {
        if (other == null)
        {
            return;
        }
        bidAskQuote_.Add(other.bidAskQuote_);
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            bidAskQuote_.AddEntriesFrom(input, _repeated_bidAskQuote_codec);
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 10:
                    {
                        bidAskQuote_.AddEntriesFrom(ref input, _repeated_bidAskQuote_codec);
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class MarketOHLC : pb::IMessage<MarketOHLC>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<MarketOHLC> _parser = new pb::MessageParser<MarketOHLC>(() => new MarketOHLC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MarketOHLC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarketOHLC()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarketOHLC(MarketOHLC other) : this()
    {
        ohlc_ = other.ohlc_.Clone();
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarketOHLC Clone()
    {
        return new MarketOHLC(this);
    }

    /// <summary>Field number for the "ohlc" field.</summary>
    public const int OhlcFieldNumber = 1;
    private static readonly pb::FieldCodec<global::UpstoxWebsocket.OHLC> _repeated_ohlc_codec
        = pb::FieldCodec.ForMessage(10, global::UpstoxWebsocket.OHLC.Parser);
    private readonly pbc::RepeatedField<global::UpstoxWebsocket.OHLC> ohlc_ = new pbc::RepeatedField<global::UpstoxWebsocket.OHLC>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::UpstoxWebsocket.OHLC> Ohlc
    {
        get { return ohlc_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as MarketOHLC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MarketOHLC other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!ohlc_.Equals(other.ohlc_)) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        hash ^= ohlc_.GetHashCode();
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      ohlc_.WriteTo(output, _repeated_ohlc_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        ohlc_.WriteTo(ref output, _repeated_ohlc_codec);
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        size += ohlc_.CalculateSize(_repeated_ohlc_codec);
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MarketOHLC other)
    {
        if (other == null)
        {
            return;
        }
        ohlc_.Add(other.ohlc_);
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ohlc_.AddEntriesFrom(input, _repeated_ohlc_codec);
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 10:
                    {
                        ohlc_.AddEntriesFrom(ref input, _repeated_ohlc_codec);
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class Quote : pb::IMessage<Quote>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<Quote> _parser = new pb::MessageParser<Quote>(() => new Quote());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Quote> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Quote()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Quote(Quote other) : this()
    {
        bq_ = other.bq_;
        bp_ = other.bp_;
        bno_ = other.bno_;
        aq_ = other.aq_;
        ap_ = other.ap_;
        ano_ = other.ano_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Quote Clone()
    {
        return new Quote(this);
    }

    /// <summary>Field number for the "bq" field.</summary>
    public const int BqFieldNumber = 1;
    private int bq_;
    /// <summary>
    ///bid quantity
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Bq
    {
        get { return bq_; }
        set
        {
            bq_ = value;
        }
    }

    /// <summary>Field number for the "bp" field.</summary>
    public const int BpFieldNumber = 2;
    private double bp_;
    /// <summary>
    ///bid price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Bp
    {
        get { return bp_; }
        set
        {
            bp_ = value;
        }
    }

    /// <summary>Field number for the "bno" field.</summary>
    public const int BnoFieldNumber = 3;
    private int bno_;
    /// <summary>
    ///bid number of orders
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Bno
    {
        get { return bno_; }
        set
        {
            bno_ = value;
        }
    }

    /// <summary>Field number for the "aq" field.</summary>
    public const int AqFieldNumber = 4;
    private int aq_;
    /// <summary>
    /// ask quantity
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Aq
    {
        get { return aq_; }
        set
        {
            aq_ = value;
        }
    }

    /// <summary>Field number for the "ap" field.</summary>
    public const int ApFieldNumber = 5;
    private double ap_;
    /// <summary>
    /// ask price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Ap
    {
        get { return ap_; }
        set
        {
            ap_ = value;
        }
    }

    /// <summary>Field number for the "ano" field.</summary>
    public const int AnoFieldNumber = 6;
    private int ano_;
    /// <summary>
    /// ask number of orders
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Ano
    {
        get { return ano_; }
        set
        {
            ano_ = value;
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as Quote);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Quote other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (Bq != other.Bq) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Bp, other.Bp)) return false;
        if (Bno != other.Bno) return false;
        if (Aq != other.Aq) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Ap, other.Ap)) return false;
        if (Ano != other.Ano) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (Bq != 0) hash ^= Bq.GetHashCode();
        if (Bp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Bp);
        if (Bno != 0) hash ^= Bno.GetHashCode();
        if (Aq != 0) hash ^= Aq.GetHashCode();
        if (Ap != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Ap);
        if (Ano != 0) hash ^= Ano.GetHashCode();
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (Bq != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Bq);
      }
      if (Bp != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Bp);
      }
      if (Bno != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Bno);
      }
      if (Aq != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Aq);
      }
      if (Ap != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Ap);
      }
      if (Ano != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Ano);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (Bq != 0)
        {
            output.WriteRawTag(8);
            output.WriteInt32(Bq);
        }
        if (Bp != 0D)
        {
            output.WriteRawTag(17);
            output.WriteDouble(Bp);
        }
        if (Bno != 0)
        {
            output.WriteRawTag(24);
            output.WriteInt32(Bno);
        }
        if (Aq != 0)
        {
            output.WriteRawTag(32);
            output.WriteInt32(Aq);
        }
        if (Ap != 0D)
        {
            output.WriteRawTag(41);
            output.WriteDouble(Ap);
        }
        if (Ano != 0)
        {
            output.WriteRawTag(48);
            output.WriteInt32(Ano);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (Bq != 0)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Bq);
        }
        if (Bp != 0D)
        {
            size += 1 + 8;
        }
        if (Bno != 0)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Bno);
        }
        if (Aq != 0)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Aq);
        }
        if (Ap != 0D)
        {
            size += 1 + 8;
        }
        if (Ano != 0)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Ano);
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Quote other)
    {
        if (other == null)
        {
            return;
        }
        if (other.Bq != 0)
        {
            Bq = other.Bq;
        }
        if (other.Bp != 0D)
        {
            Bp = other.Bp;
        }
        if (other.Bno != 0)
        {
            Bno = other.Bno;
        }
        if (other.Aq != 0)
        {
            Aq = other.Aq;
        }
        if (other.Ap != 0D)
        {
            Ap = other.Ap;
        }
        if (other.Ano != 0)
        {
            Ano = other.Ano;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Bq = input.ReadInt32();
            break;
          }
          case 17: {
            Bp = input.ReadDouble();
            break;
          }
          case 24: {
            Bno = input.ReadInt32();
            break;
          }
          case 32: {
            Aq = input.ReadInt32();
            break;
          }
          case 41: {
            Ap = input.ReadDouble();
            break;
          }
          case 48: {
            Ano = input.ReadInt32();
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 8:
                    {
                        Bq = input.ReadInt32();
                        break;
                    }
                case 17:
                    {
                        Bp = input.ReadDouble();
                        break;
                    }
                case 24:
                    {
                        Bno = input.ReadInt32();
                        break;
                    }
                case 32:
                    {
                        Aq = input.ReadInt32();
                        break;
                    }
                case 41:
                    {
                        Ap = input.ReadDouble();
                        break;
                    }
                case 48:
                    {
                        Ano = input.ReadInt32();
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class OptionGreeks : pb::IMessage<OptionGreeks>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<OptionGreeks> _parser = new pb::MessageParser<OptionGreeks>(() => new OptionGreeks());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OptionGreeks> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptionGreeks()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptionGreeks(OptionGreeks other) : this()
    {
        op_ = other.op_;
        up_ = other.up_;
        iv_ = other.iv_;
        delta_ = other.delta_;
        theta_ = other.theta_;
        gamma_ = other.gamma_;
        vega_ = other.vega_;
        rho_ = other.rho_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptionGreeks Clone()
    {
        return new OptionGreeks(this);
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 1;
    private double op_;
    /// <summary>
    /// option price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Op
    {
        get { return op_; }
        set
        {
            op_ = value;
        }
    }

    /// <summary>Field number for the "up" field.</summary>
    public const int UpFieldNumber = 2;
    private double up_;
    /// <summary>
    ///underlying price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Up
    {
        get { return up_; }
        set
        {
            up_ = value;
        }
    }

    /// <summary>Field number for the "iv" field.</summary>
    public const int IvFieldNumber = 3;
    private double iv_;
    /// <summary>
    /// implied volatility
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Iv
    {
        get { return iv_; }
        set
        {
            iv_ = value;
        }
    }

    /// <summary>Field number for the "delta" field.</summary>
    public const int DeltaFieldNumber = 4;
    private double delta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Delta
    {
        get { return delta_; }
        set
        {
            delta_ = value;
        }
    }

    /// <summary>Field number for the "theta" field.</summary>
    public const int ThetaFieldNumber = 5;
    private double theta_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Theta
    {
        get { return theta_; }
        set
        {
            theta_ = value;
        }
    }

    /// <summary>Field number for the "gamma" field.</summary>
    public const int GammaFieldNumber = 6;
    private double gamma_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Gamma
    {
        get { return gamma_; }
        set
        {
            gamma_ = value;
        }
    }

    /// <summary>Field number for the "vega" field.</summary>
    public const int VegaFieldNumber = 7;
    private double vega_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Vega
    {
        get { return vega_; }
        set
        {
            vega_ = value;
        }
    }

    /// <summary>Field number for the "rho" field.</summary>
    public const int RhoFieldNumber = 8;
    private double rho_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Rho
    {
        get { return rho_; }
        set
        {
            rho_ = value;
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as OptionGreeks);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OptionGreeks other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Op, other.Op)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Up, other.Up)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Iv, other.Iv)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Delta, other.Delta)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Theta, other.Theta)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Gamma, other.Gamma)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Vega, other.Vega)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Rho, other.Rho)) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (Op != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Op);
        if (Up != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Up);
        if (Iv != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Iv);
        if (Delta != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Delta);
        if (Theta != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Theta);
        if (Gamma != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Gamma);
        if (Vega != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Vega);
        if (Rho != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Rho);
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (Op != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Op);
      }
      if (Up != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Up);
      }
      if (Iv != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Iv);
      }
      if (Delta != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Delta);
      }
      if (Theta != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Theta);
      }
      if (Gamma != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(Gamma);
      }
      if (Vega != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Vega);
      }
      if (Rho != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(Rho);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (Op != 0D)
        {
            output.WriteRawTag(9);
            output.WriteDouble(Op);
        }
        if (Up != 0D)
        {
            output.WriteRawTag(17);
            output.WriteDouble(Up);
        }
        if (Iv != 0D)
        {
            output.WriteRawTag(25);
            output.WriteDouble(Iv);
        }
        if (Delta != 0D)
        {
            output.WriteRawTag(33);
            output.WriteDouble(Delta);
        }
        if (Theta != 0D)
        {
            output.WriteRawTag(41);
            output.WriteDouble(Theta);
        }
        if (Gamma != 0D)
        {
            output.WriteRawTag(49);
            output.WriteDouble(Gamma);
        }
        if (Vega != 0D)
        {
            output.WriteRawTag(57);
            output.WriteDouble(Vega);
        }
        if (Rho != 0D)
        {
            output.WriteRawTag(65);
            output.WriteDouble(Rho);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (Op != 0D)
        {
            size += 1 + 8;
        }
        if (Up != 0D)
        {
            size += 1 + 8;
        }
        if (Iv != 0D)
        {
            size += 1 + 8;
        }
        if (Delta != 0D)
        {
            size += 1 + 8;
        }
        if (Theta != 0D)
        {
            size += 1 + 8;
        }
        if (Gamma != 0D)
        {
            size += 1 + 8;
        }
        if (Vega != 0D)
        {
            size += 1 + 8;
        }
        if (Rho != 0D)
        {
            size += 1 + 8;
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OptionGreeks other)
    {
        if (other == null)
        {
            return;
        }
        if (other.Op != 0D)
        {
            Op = other.Op;
        }
        if (other.Up != 0D)
        {
            Up = other.Up;
        }
        if (other.Iv != 0D)
        {
            Iv = other.Iv;
        }
        if (other.Delta != 0D)
        {
            Delta = other.Delta;
        }
        if (other.Theta != 0D)
        {
            Theta = other.Theta;
        }
        if (other.Gamma != 0D)
        {
            Gamma = other.Gamma;
        }
        if (other.Vega != 0D)
        {
            Vega = other.Vega;
        }
        if (other.Rho != 0D)
        {
            Rho = other.Rho;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            Op = input.ReadDouble();
            break;
          }
          case 17: {
            Up = input.ReadDouble();
            break;
          }
          case 25: {
            Iv = input.ReadDouble();
            break;
          }
          case 33: {
            Delta = input.ReadDouble();
            break;
          }
          case 41: {
            Theta = input.ReadDouble();
            break;
          }
          case 49: {
            Gamma = input.ReadDouble();
            break;
          }
          case 57: {
            Vega = input.ReadDouble();
            break;
          }
          case 65: {
            Rho = input.ReadDouble();
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 9:
                    {
                        Op = input.ReadDouble();
                        break;
                    }
                case 17:
                    {
                        Up = input.ReadDouble();
                        break;
                    }
                case 25:
                    {
                        Iv = input.ReadDouble();
                        break;
                    }
                case 33:
                    {
                        Delta = input.ReadDouble();
                        break;
                    }
                case 41:
                    {
                        Theta = input.ReadDouble();
                        break;
                    }
                case 49:
                    {
                        Gamma = input.ReadDouble();
                        break;
                    }
                case 57:
                    {
                        Vega = input.ReadDouble();
                        break;
                    }
                case 65:
                    {
                        Rho = input.ReadDouble();
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class ExtendedFeedDetails : pb::IMessage<ExtendedFeedDetails>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<ExtendedFeedDetails> _parser = new pb::MessageParser<ExtendedFeedDetails>(() => new ExtendedFeedDetails());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExtendedFeedDetails> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtendedFeedDetails()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtendedFeedDetails(ExtendedFeedDetails other) : this()
    {
        atp_ = other.atp_;
        cp_ = other.cp_;
        vtt_ = other.vtt_;
        oi_ = other.oi_;
        changeOi_ = other.changeOi_;
        lastClose_ = other.lastClose_;
        tbq_ = other.tbq_;
        tsq_ = other.tsq_;
        close_ = other.close_;
        lc_ = other.lc_;
        uc_ = other.uc_;
        yh_ = other.yh_;
        yl_ = other.yl_;
        fp_ = other.fp_;
        fv_ = other.fv_;
        mbpBuy_ = other.mbpBuy_;
        mbpSell_ = other.mbpSell_;
        tv_ = other.tv_;
        dhoi_ = other.dhoi_;
        dloi_ = other.dloi_;
        sp_ = other.sp_;
        poi_ = other.poi_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtendedFeedDetails Clone()
    {
        return new ExtendedFeedDetails(this);
    }

    /// <summary>Field number for the "atp" field.</summary>
    public const int AtpFieldNumber = 1;
    private double atp_;
    /// <summary>
    ///avg traded price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Atp
    {
        get { return atp_; }
        set
        {
            atp_ = value;
        }
    }

    /// <summary>Field number for the "cp" field.</summary>
    public const int CpFieldNumber = 2;
    private double cp_;
    /// <summary>
    ///close price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Cp
    {
        get { return cp_; }
        set
        {
            cp_ = value;
        }
    }

    /// <summary>Field number for the "vtt" field.</summary>
    public const int VttFieldNumber = 3;
    private long vtt_;
    /// <summary>
    ///volume traded today
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Vtt
    {
        get { return vtt_; }
        set
        {
            vtt_ = value;
        }
    }

    /// <summary>Field number for the "oi" field.</summary>
    public const int OiFieldNumber = 4;
    private double oi_;
    /// <summary>
    ///open interest
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Oi
    {
        get { return oi_; }
        set
        {
            oi_ = value;
        }
    }

    /// <summary>Field number for the "changeOi" field.</summary>
    public const int ChangeOiFieldNumber = 5;
    private double changeOi_;
    /// <summary>
    ///change oi
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double ChangeOi
    {
        get { return changeOi_; }
        set
        {
            changeOi_ = value;
        }
    }

    /// <summary>Field number for the "lastClose" field.</summary>
    public const int LastCloseFieldNumber = 6;
    private double lastClose_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double LastClose
    {
        get { return lastClose_; }
        set
        {
            lastClose_ = value;
        }
    }

    /// <summary>Field number for the "tbq" field.</summary>
    public const int TbqFieldNumber = 7;
    private double tbq_;
    /// <summary>
    ///total buy quantity
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Tbq
    {
        get { return tbq_; }
        set
        {
            tbq_ = value;
        }
    }

    /// <summary>Field number for the "tsq" field.</summary>
    public const int TsqFieldNumber = 8;
    private double tsq_;
    /// <summary>
    ///total sell quantity
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Tsq
    {
        get { return tsq_; }
        set
        {
            tsq_ = value;
        }
    }

    /// <summary>Field number for the "close" field.</summary>
    public const int CloseFieldNumber = 9;
    private double close_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Close
    {
        get { return close_; }
        set
        {
            close_ = value;
        }
    }

    /// <summary>Field number for the "lc" field.</summary>
    public const int LcFieldNumber = 10;
    private double lc_;
    /// <summary>
    ///lower circuit
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Lc
    {
        get { return lc_; }
        set
        {
            lc_ = value;
        }
    }

    /// <summary>Field number for the "uc" field.</summary>
    public const int UcFieldNumber = 11;
    private double uc_;
    /// <summary>
    ///upper circuit
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Uc
    {
        get { return uc_; }
        set
        {
            uc_ = value;
        }
    }

    /// <summary>Field number for the "yh" field.</summary>
    public const int YhFieldNumber = 12;
    private double yh_;
    /// <summary>
    ///yearly high
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Yh
    {
        get { return yh_; }
        set
        {
            yh_ = value;
        }
    }

    /// <summary>Field number for the "yl" field.</summary>
    public const int YlFieldNumber = 13;
    private double yl_;
    /// <summary>
    ///yearly low
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Yl
    {
        get { return yl_; }
        set
        {
            yl_ = value;
        }
    }

    /// <summary>Field number for the "fp" field.</summary>
    public const int FpFieldNumber = 14;
    private double fp_;
    /// <summary>
    ///fill price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Fp
    {
        get { return fp_; }
        set
        {
            fp_ = value;
        }
    }

    /// <summary>Field number for the "fv" field.</summary>
    public const int FvFieldNumber = 15;
    private int fv_;
    /// <summary>
    ///fill volume
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Fv
    {
        get { return fv_; }
        set
        {
            fv_ = value;
        }
    }

    /// <summary>Field number for the "mbpBuy" field.</summary>
    public const int MbpBuyFieldNumber = 16;
    private long mbpBuy_;
    /// <summary>
    ///mbp buy
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long MbpBuy
    {
        get { return mbpBuy_; }
        set
        {
            mbpBuy_ = value;
        }
    }

    /// <summary>Field number for the "mbpSell" field.</summary>
    public const int MbpSellFieldNumber = 17;
    private long mbpSell_;
    /// <summary>
    ///mbp sell
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long MbpSell
    {
        get { return mbpSell_; }
        set
        {
            mbpSell_ = value;
        }
    }

    /// <summary>Field number for the "tv" field.</summary>
    public const int TvFieldNumber = 18;
    private long tv_;
    /// <summary>
    ///traded volume
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Tv
    {
        get { return tv_; }
        set
        {
            tv_ = value;
        }
    }

    /// <summary>Field number for the "dhoi" field.</summary>
    public const int DhoiFieldNumber = 19;
    private double dhoi_;
    /// <summary>
    ///day high open interest
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Dhoi
    {
        get { return dhoi_; }
        set
        {
            dhoi_ = value;
        }
    }

    /// <summary>Field number for the "dloi" field.</summary>
    public const int DloiFieldNumber = 20;
    private double dloi_;
    /// <summary>
    ///day low open interest
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Dloi
    {
        get { return dloi_; }
        set
        {
            dloi_ = value;
        }
    }

    /// <summary>Field number for the "sp" field.</summary>
    public const int SpFieldNumber = 21;
    private double sp_;
    /// <summary>
    ///spot price
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Sp
    {
        get { return sp_; }
        set
        {
            sp_ = value;
        }
    }

    /// <summary>Field number for the "poi" field.</summary>
    public const int PoiFieldNumber = 22;
    private double poi_;
    /// <summary>
    ///previous open interest
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Poi
    {
        get { return poi_; }
        set
        {
            poi_ = value;
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as ExtendedFeedDetails);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExtendedFeedDetails other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Atp, other.Atp)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Cp, other.Cp)) return false;
        if (Vtt != other.Vtt) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Oi, other.Oi)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(ChangeOi, other.ChangeOi)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LastClose, other.LastClose)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Tbq, other.Tbq)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Tsq, other.Tsq)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Close, other.Close)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Lc, other.Lc)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Uc, other.Uc)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Yh, other.Yh)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Yl, other.Yl)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Fp, other.Fp)) return false;
        if (Fv != other.Fv) return false;
        if (MbpBuy != other.MbpBuy) return false;
        if (MbpSell != other.MbpSell) return false;
        if (Tv != other.Tv) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Dhoi, other.Dhoi)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Dloi, other.Dloi)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Sp, other.Sp)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Poi, other.Poi)) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (Atp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Atp);
        if (Cp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Cp);
        if (Vtt != 0L) hash ^= Vtt.GetHashCode();
        if (Oi != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Oi);
        if (ChangeOi != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(ChangeOi);
        if (LastClose != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LastClose);
        if (Tbq != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Tbq);
        if (Tsq != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Tsq);
        if (Close != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Close);
        if (Lc != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Lc);
        if (Uc != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Uc);
        if (Yh != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Yh);
        if (Yl != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Yl);
        if (Fp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Fp);
        if (Fv != 0) hash ^= Fv.GetHashCode();
        if (MbpBuy != 0L) hash ^= MbpBuy.GetHashCode();
        if (MbpSell != 0L) hash ^= MbpSell.GetHashCode();
        if (Tv != 0L) hash ^= Tv.GetHashCode();
        if (Dhoi != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Dhoi);
        if (Dloi != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Dloi);
        if (Sp != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Sp);
        if (Poi != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Poi);
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (Atp != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Atp);
      }
      if (Cp != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Cp);
      }
      if (Vtt != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Vtt);
      }
      if (Oi != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Oi);
      }
      if (ChangeOi != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(ChangeOi);
      }
      if (LastClose != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(LastClose);
      }
      if (Tbq != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(Tbq);
      }
      if (Tsq != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(Tsq);
      }
      if (Close != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(Close);
      }
      if (Lc != 0D) {
        output.WriteRawTag(81);
        output.WriteDouble(Lc);
      }
      if (Uc != 0D) {
        output.WriteRawTag(89);
        output.WriteDouble(Uc);
      }
      if (Yh != 0D) {
        output.WriteRawTag(97);
        output.WriteDouble(Yh);
      }
      if (Yl != 0D) {
        output.WriteRawTag(105);
        output.WriteDouble(Yl);
      }
      if (Fp != 0D) {
        output.WriteRawTag(113);
        output.WriteDouble(Fp);
      }
      if (Fv != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Fv);
      }
      if (MbpBuy != 0L) {
        output.WriteRawTag(128, 1);
        output.WriteInt64(MbpBuy);
      }
      if (MbpSell != 0L) {
        output.WriteRawTag(136, 1);
        output.WriteInt64(MbpSell);
      }
      if (Tv != 0L) {
        output.WriteRawTag(144, 1);
        output.WriteInt64(Tv);
      }
      if (Dhoi != 0D) {
        output.WriteRawTag(153, 1);
        output.WriteDouble(Dhoi);
      }
      if (Dloi != 0D) {
        output.WriteRawTag(161, 1);
        output.WriteDouble(Dloi);
      }
      if (Sp != 0D) {
        output.WriteRawTag(169, 1);
        output.WriteDouble(Sp);
      }
      if (Poi != 0D) {
        output.WriteRawTag(177, 1);
        output.WriteDouble(Poi);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (Atp != 0D)
        {
            output.WriteRawTag(9);
            output.WriteDouble(Atp);
        }
        if (Cp != 0D)
        {
            output.WriteRawTag(17);
            output.WriteDouble(Cp);
        }
        if (Vtt != 0L)
        {
            output.WriteRawTag(24);
            output.WriteInt64(Vtt);
        }
        if (Oi != 0D)
        {
            output.WriteRawTag(33);
            output.WriteDouble(Oi);
        }
        if (ChangeOi != 0D)
        {
            output.WriteRawTag(41);
            output.WriteDouble(ChangeOi);
        }
        if (LastClose != 0D)
        {
            output.WriteRawTag(49);
            output.WriteDouble(LastClose);
        }
        if (Tbq != 0D)
        {
            output.WriteRawTag(57);
            output.WriteDouble(Tbq);
        }
        if (Tsq != 0D)
        {
            output.WriteRawTag(65);
            output.WriteDouble(Tsq);
        }
        if (Close != 0D)
        {
            output.WriteRawTag(73);
            output.WriteDouble(Close);
        }
        if (Lc != 0D)
        {
            output.WriteRawTag(81);
            output.WriteDouble(Lc);
        }
        if (Uc != 0D)
        {
            output.WriteRawTag(89);
            output.WriteDouble(Uc);
        }
        if (Yh != 0D)
        {
            output.WriteRawTag(97);
            output.WriteDouble(Yh);
        }
        if (Yl != 0D)
        {
            output.WriteRawTag(105);
            output.WriteDouble(Yl);
        }
        if (Fp != 0D)
        {
            output.WriteRawTag(113);
            output.WriteDouble(Fp);
        }
        if (Fv != 0)
        {
            output.WriteRawTag(120);
            output.WriteInt32(Fv);
        }
        if (MbpBuy != 0L)
        {
            output.WriteRawTag(128, 1);
            output.WriteInt64(MbpBuy);
        }
        if (MbpSell != 0L)
        {
            output.WriteRawTag(136, 1);
            output.WriteInt64(MbpSell);
        }
        if (Tv != 0L)
        {
            output.WriteRawTag(144, 1);
            output.WriteInt64(Tv);
        }
        if (Dhoi != 0D)
        {
            output.WriteRawTag(153, 1);
            output.WriteDouble(Dhoi);
        }
        if (Dloi != 0D)
        {
            output.WriteRawTag(161, 1);
            output.WriteDouble(Dloi);
        }
        if (Sp != 0D)
        {
            output.WriteRawTag(169, 1);
            output.WriteDouble(Sp);
        }
        if (Poi != 0D)
        {
            output.WriteRawTag(177, 1);
            output.WriteDouble(Poi);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (Atp != 0D)
        {
            size += 1 + 8;
        }
        if (Cp != 0D)
        {
            size += 1 + 8;
        }
        if (Vtt != 0L)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Vtt);
        }
        if (Oi != 0D)
        {
            size += 1 + 8;
        }
        if (ChangeOi != 0D)
        {
            size += 1 + 8;
        }
        if (LastClose != 0D)
        {
            size += 1 + 8;
        }
        if (Tbq != 0D)
        {
            size += 1 + 8;
        }
        if (Tsq != 0D)
        {
            size += 1 + 8;
        }
        if (Close != 0D)
        {
            size += 1 + 8;
        }
        if (Lc != 0D)
        {
            size += 1 + 8;
        }
        if (Uc != 0D)
        {
            size += 1 + 8;
        }
        if (Yh != 0D)
        {
            size += 1 + 8;
        }
        if (Yl != 0D)
        {
            size += 1 + 8;
        }
        if (Fp != 0D)
        {
            size += 1 + 8;
        }
        if (Fv != 0)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fv);
        }
        if (MbpBuy != 0L)
        {
            size += 2 + pb::CodedOutputStream.ComputeInt64Size(MbpBuy);
        }
        if (MbpSell != 0L)
        {
            size += 2 + pb::CodedOutputStream.ComputeInt64Size(MbpSell);
        }
        if (Tv != 0L)
        {
            size += 2 + pb::CodedOutputStream.ComputeInt64Size(Tv);
        }
        if (Dhoi != 0D)
        {
            size += 2 + 8;
        }
        if (Dloi != 0D)
        {
            size += 2 + 8;
        }
        if (Sp != 0D)
        {
            size += 2 + 8;
        }
        if (Poi != 0D)
        {
            size += 2 + 8;
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExtendedFeedDetails other)
    {
        if (other == null)
        {
            return;
        }
        if (other.Atp != 0D)
        {
            Atp = other.Atp;
        }
        if (other.Cp != 0D)
        {
            Cp = other.Cp;
        }
        if (other.Vtt != 0L)
        {
            Vtt = other.Vtt;
        }
        if (other.Oi != 0D)
        {
            Oi = other.Oi;
        }
        if (other.ChangeOi != 0D)
        {
            ChangeOi = other.ChangeOi;
        }
        if (other.LastClose != 0D)
        {
            LastClose = other.LastClose;
        }
        if (other.Tbq != 0D)
        {
            Tbq = other.Tbq;
        }
        if (other.Tsq != 0D)
        {
            Tsq = other.Tsq;
        }
        if (other.Close != 0D)
        {
            Close = other.Close;
        }
        if (other.Lc != 0D)
        {
            Lc = other.Lc;
        }
        if (other.Uc != 0D)
        {
            Uc = other.Uc;
        }
        if (other.Yh != 0D)
        {
            Yh = other.Yh;
        }
        if (other.Yl != 0D)
        {
            Yl = other.Yl;
        }
        if (other.Fp != 0D)
        {
            Fp = other.Fp;
        }
        if (other.Fv != 0)
        {
            Fv = other.Fv;
        }
        if (other.MbpBuy != 0L)
        {
            MbpBuy = other.MbpBuy;
        }
        if (other.MbpSell != 0L)
        {
            MbpSell = other.MbpSell;
        }
        if (other.Tv != 0L)
        {
            Tv = other.Tv;
        }
        if (other.Dhoi != 0D)
        {
            Dhoi = other.Dhoi;
        }
        if (other.Dloi != 0D)
        {
            Dloi = other.Dloi;
        }
        if (other.Sp != 0D)
        {
            Sp = other.Sp;
        }
        if (other.Poi != 0D)
        {
            Poi = other.Poi;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            Atp = input.ReadDouble();
            break;
          }
          case 17: {
            Cp = input.ReadDouble();
            break;
          }
          case 24: {
            Vtt = input.ReadInt64();
            break;
          }
          case 33: {
            Oi = input.ReadDouble();
            break;
          }
          case 41: {
            ChangeOi = input.ReadDouble();
            break;
          }
          case 49: {
            LastClose = input.ReadDouble();
            break;
          }
          case 57: {
            Tbq = input.ReadDouble();
            break;
          }
          case 65: {
            Tsq = input.ReadDouble();
            break;
          }
          case 73: {
            Close = input.ReadDouble();
            break;
          }
          case 81: {
            Lc = input.ReadDouble();
            break;
          }
          case 89: {
            Uc = input.ReadDouble();
            break;
          }
          case 97: {
            Yh = input.ReadDouble();
            break;
          }
          case 105: {
            Yl = input.ReadDouble();
            break;
          }
          case 113: {
            Fp = input.ReadDouble();
            break;
          }
          case 120: {
            Fv = input.ReadInt32();
            break;
          }
          case 128: {
            MbpBuy = input.ReadInt64();
            break;
          }
          case 136: {
            MbpSell = input.ReadInt64();
            break;
          }
          case 144: {
            Tv = input.ReadInt64();
            break;
          }
          case 153: {
            Dhoi = input.ReadDouble();
            break;
          }
          case 161: {
            Dloi = input.ReadDouble();
            break;
          }
          case 169: {
            Sp = input.ReadDouble();
            break;
          }
          case 177: {
            Poi = input.ReadDouble();
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 9:
                    {
                        Atp = input.ReadDouble();
                        break;
                    }
                case 17:
                    {
                        Cp = input.ReadDouble();
                        break;
                    }
                case 24:
                    {
                        Vtt = input.ReadInt64();
                        break;
                    }
                case 33:
                    {
                        Oi = input.ReadDouble();
                        break;
                    }
                case 41:
                    {
                        ChangeOi = input.ReadDouble();
                        break;
                    }
                case 49:
                    {
                        LastClose = input.ReadDouble();
                        break;
                    }
                case 57:
                    {
                        Tbq = input.ReadDouble();
                        break;
                    }
                case 65:
                    {
                        Tsq = input.ReadDouble();
                        break;
                    }
                case 73:
                    {
                        Close = input.ReadDouble();
                        break;
                    }
                case 81:
                    {
                        Lc = input.ReadDouble();
                        break;
                    }
                case 89:
                    {
                        Uc = input.ReadDouble();
                        break;
                    }
                case 97:
                    {
                        Yh = input.ReadDouble();
                        break;
                    }
                case 105:
                    {
                        Yl = input.ReadDouble();
                        break;
                    }
                case 113:
                    {
                        Fp = input.ReadDouble();
                        break;
                    }
                case 120:
                    {
                        Fv = input.ReadInt32();
                        break;
                    }
                case 128:
                    {
                        MbpBuy = input.ReadInt64();
                        break;
                    }
                case 136:
                    {
                        MbpSell = input.ReadInt64();
                        break;
                    }
                case 144:
                    {
                        Tv = input.ReadInt64();
                        break;
                    }
                case 153:
                    {
                        Dhoi = input.ReadDouble();
                        break;
                    }
                case 161:
                    {
                        Dloi = input.ReadDouble();
                        break;
                    }
                case 169:
                    {
                        Sp = input.ReadDouble();
                        break;
                    }
                case 177:
                    {
                        Poi = input.ReadDouble();
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class OHLC : pb::IMessage<OHLC>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<OHLC> _parser = new pb::MessageParser<OHLC>(() => new OHLC());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OHLC> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OHLC()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OHLC(OHLC other) : this()
    {
        interval_ = other.interval_;
        open_ = other.open_;
        high_ = other.high_;
        low_ = other.low_;
        close_ = other.close_;
        volume_ = other.volume_;
        ts_ = other.ts_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OHLC Clone()
    {
        return new OHLC(this);
    }

    /// <summary>Field number for the "interval" field.</summary>
    public const int IntervalFieldNumber = 1;
    private string interval_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Interval
    {
        get { return interval_; }
        set
        {
            interval_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        }
    }

    /// <summary>Field number for the "open" field.</summary>
    public const int OpenFieldNumber = 2;
    private double open_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Open
    {
        get { return open_; }
        set
        {
            open_ = value;
        }
    }

    /// <summary>Field number for the "high" field.</summary>
    public const int HighFieldNumber = 3;
    private double high_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double High
    {
        get { return high_; }
        set
        {
            high_ = value;
        }
    }

    /// <summary>Field number for the "low" field.</summary>
    public const int LowFieldNumber = 4;
    private double low_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Low
    {
        get { return low_; }
        set
        {
            low_ = value;
        }
    }

    /// <summary>Field number for the "close" field.</summary>
    public const int CloseFieldNumber = 5;
    private double close_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Close
    {
        get { return close_; }
        set
        {
            close_ = value;
        }
    }

    /// <summary>Field number for the "volume" field.</summary>
    public const int VolumeFieldNumber = 6;
    private int volume_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Volume
    {
        get { return volume_; }
        set
        {
            volume_ = value;
        }
    }

    /// <summary>Field number for the "ts" field.</summary>
    public const int TsFieldNumber = 7;
    private long ts_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Ts
    {
        get { return ts_; }
        set
        {
            ts_ = value;
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as OHLC);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OHLC other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (Interval != other.Interval) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Open, other.Open)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(High, other.High)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Low, other.Low)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Close, other.Close)) return false;
        if (Volume != other.Volume) return false;
        if (Ts != other.Ts) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (Interval.Length != 0) hash ^= Interval.GetHashCode();
        if (Open != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Open);
        if (High != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(High);
        if (Low != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Low);
        if (Close != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Close);
        if (Volume != 0) hash ^= Volume.GetHashCode();
        if (Ts != 0L) hash ^= Ts.GetHashCode();
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (Interval.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Interval);
      }
      if (Open != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Open);
      }
      if (High != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(High);
      }
      if (Low != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Low);
      }
      if (Close != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Close);
      }
      if (Volume != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Volume);
      }
      if (Ts != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(Ts);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (Interval.Length != 0)
        {
            output.WriteRawTag(10);
            output.WriteString(Interval);
        }
        if (Open != 0D)
        {
            output.WriteRawTag(17);
            output.WriteDouble(Open);
        }
        if (High != 0D)
        {
            output.WriteRawTag(25);
            output.WriteDouble(High);
        }
        if (Low != 0D)
        {
            output.WriteRawTag(33);
            output.WriteDouble(Low);
        }
        if (Close != 0D)
        {
            output.WriteRawTag(41);
            output.WriteDouble(Close);
        }
        if (Volume != 0)
        {
            output.WriteRawTag(48);
            output.WriteInt32(Volume);
        }
        if (Ts != 0L)
        {
            output.WriteRawTag(56);
            output.WriteInt64(Ts);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (Interval.Length != 0)
        {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Interval);
        }
        if (Open != 0D)
        {
            size += 1 + 8;
        }
        if (High != 0D)
        {
            size += 1 + 8;
        }
        if (Low != 0D)
        {
            size += 1 + 8;
        }
        if (Close != 0D)
        {
            size += 1 + 8;
        }
        if (Volume != 0)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Volume);
        }
        if (Ts != 0L)
        {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Ts);
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OHLC other)
    {
        if (other == null)
        {
            return;
        }
        if (other.Interval.Length != 0)
        {
            Interval = other.Interval;
        }
        if (other.Open != 0D)
        {
            Open = other.Open;
        }
        if (other.High != 0D)
        {
            High = other.High;
        }
        if (other.Low != 0D)
        {
            Low = other.Low;
        }
        if (other.Close != 0D)
        {
            Close = other.Close;
        }
        if (other.Volume != 0)
        {
            Volume = other.Volume;
        }
        if (other.Ts != 0L)
        {
            Ts = other.Ts;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Interval = input.ReadString();
            break;
          }
          case 17: {
            Open = input.ReadDouble();
            break;
          }
          case 25: {
            High = input.ReadDouble();
            break;
          }
          case 33: {
            Low = input.ReadDouble();
            break;
          }
          case 41: {
            Close = input.ReadDouble();
            break;
          }
          case 48: {
            Volume = input.ReadInt32();
            break;
          }
          case 56: {
            Ts = input.ReadInt64();
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 10:
                    {
                        Interval = input.ReadString();
                        break;
                    }
                case 17:
                    {
                        Open = input.ReadDouble();
                        break;
                    }
                case 25:
                    {
                        High = input.ReadDouble();
                        break;
                    }
                case 33:
                    {
                        Low = input.ReadDouble();
                        break;
                    }
                case 41:
                    {
                        Close = input.ReadDouble();
                        break;
                    }
                case 48:
                    {
                        Volume = input.ReadInt32();
                        break;
                    }
                case 56:
                    {
                        Ts = input.ReadInt64();
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class MarketFullFeed : pb::IMessage<MarketFullFeed>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<MarketFullFeed> _parser = new pb::MessageParser<MarketFullFeed>(() => new MarketFullFeed());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MarketFullFeed> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[7]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarketFullFeed()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarketFullFeed(MarketFullFeed other) : this()
    {
        ltpc_ = other.ltpc_ != null ? other.ltpc_.Clone() : null;
        marketLevel_ = other.marketLevel_ != null ? other.marketLevel_.Clone() : null;
        optionGreeks_ = other.optionGreeks_ != null ? other.optionGreeks_.Clone() : null;
        marketOHLC_ = other.marketOHLC_ != null ? other.marketOHLC_.Clone() : null;
        eFeedDetails_ = other.eFeedDetails_ != null ? other.eFeedDetails_.Clone() : null;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarketFullFeed Clone()
    {
        return new MarketFullFeed(this);
    }

    /// <summary>Field number for the "ltpc" field.</summary>
    public const int LtpcFieldNumber = 1;
    private global::UpstoxWebsocket.LTPC ltpc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.LTPC Ltpc
    {
        get { return ltpc_; }
        set
        {
            ltpc_ = value;
        }
    }

    /// <summary>Field number for the "marketLevel" field.</summary>
    public const int MarketLevelFieldNumber = 2;
    private global::UpstoxWebsocket.MarketLevel marketLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.MarketLevel MarketLevel
    {
        get { return marketLevel_; }
        set
        {
            marketLevel_ = value;
        }
    }

    /// <summary>Field number for the "optionGreeks" field.</summary>
    public const int OptionGreeksFieldNumber = 3;
    private global::UpstoxWebsocket.OptionGreeks optionGreeks_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.OptionGreeks OptionGreeks
    {
        get { return optionGreeks_; }
        set
        {
            optionGreeks_ = value;
        }
    }

    /// <summary>Field number for the "marketOHLC" field.</summary>
    public const int MarketOHLCFieldNumber = 4;
    private global::UpstoxWebsocket.MarketOHLC marketOHLC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.MarketOHLC MarketOHLC
    {
        get { return marketOHLC_; }
        set
        {
            marketOHLC_ = value;
        }
    }

    /// <summary>Field number for the "eFeedDetails" field.</summary>
    public const int EFeedDetailsFieldNumber = 5;
    private global::UpstoxWebsocket.ExtendedFeedDetails eFeedDetails_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.ExtendedFeedDetails EFeedDetails
    {
        get { return eFeedDetails_; }
        set
        {
            eFeedDetails_ = value;
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as MarketFullFeed);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MarketFullFeed other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!object.Equals(Ltpc, other.Ltpc)) return false;
        if (!object.Equals(MarketLevel, other.MarketLevel)) return false;
        if (!object.Equals(OptionGreeks, other.OptionGreeks)) return false;
        if (!object.Equals(MarketOHLC, other.MarketOHLC)) return false;
        if (!object.Equals(EFeedDetails, other.EFeedDetails)) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (ltpc_ != null) hash ^= Ltpc.GetHashCode();
        if (marketLevel_ != null) hash ^= MarketLevel.GetHashCode();
        if (optionGreeks_ != null) hash ^= OptionGreeks.GetHashCode();
        if (marketOHLC_ != null) hash ^= MarketOHLC.GetHashCode();
        if (eFeedDetails_ != null) hash ^= EFeedDetails.GetHashCode();
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (ltpc_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Ltpc);
      }
      if (marketLevel_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MarketLevel);
      }
      if (optionGreeks_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OptionGreeks);
      }
      if (marketOHLC_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(MarketOHLC);
      }
      if (eFeedDetails_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(EFeedDetails);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (ltpc_ != null)
        {
            output.WriteRawTag(10);
            output.WriteMessage(Ltpc);
        }
        if (marketLevel_ != null)
        {
            output.WriteRawTag(18);
            output.WriteMessage(MarketLevel);
        }
        if (optionGreeks_ != null)
        {
            output.WriteRawTag(26);
            output.WriteMessage(OptionGreeks);
        }
        if (marketOHLC_ != null)
        {
            output.WriteRawTag(34);
            output.WriteMessage(MarketOHLC);
        }
        if (eFeedDetails_ != null)
        {
            output.WriteRawTag(42);
            output.WriteMessage(EFeedDetails);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (ltpc_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ltpc);
        }
        if (marketLevel_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(MarketLevel);
        }
        if (optionGreeks_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(OptionGreeks);
        }
        if (marketOHLC_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(MarketOHLC);
        }
        if (eFeedDetails_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(EFeedDetails);
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MarketFullFeed other)
    {
        if (other == null)
        {
            return;
        }
        if (other.ltpc_ != null)
        {
            if (ltpc_ == null)
            {
                Ltpc = new global::UpstoxWebsocket.LTPC();
            }
            Ltpc.MergeFrom(other.Ltpc);
        }
        if (other.marketLevel_ != null)
        {
            if (marketLevel_ == null)
            {
                MarketLevel = new global::UpstoxWebsocket.MarketLevel();
            }
            MarketLevel.MergeFrom(other.MarketLevel);
        }
        if (other.optionGreeks_ != null)
        {
            if (optionGreeks_ == null)
            {
                OptionGreeks = new global::UpstoxWebsocket.OptionGreeks();
            }
            OptionGreeks.MergeFrom(other.OptionGreeks);
        }
        if (other.marketOHLC_ != null)
        {
            if (marketOHLC_ == null)
            {
                MarketOHLC = new global::UpstoxWebsocket.MarketOHLC();
            }
            MarketOHLC.MergeFrom(other.MarketOHLC);
        }
        if (other.eFeedDetails_ != null)
        {
            if (eFeedDetails_ == null)
            {
                EFeedDetails = new global::UpstoxWebsocket.ExtendedFeedDetails();
            }
            EFeedDetails.MergeFrom(other.EFeedDetails);
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (ltpc_ == null) {
              Ltpc = new global::UpstoxWebsocket.LTPC();
            }
            input.ReadMessage(Ltpc);
            break;
          }
          case 18: {
            if (marketLevel_ == null) {
              MarketLevel = new global::UpstoxWebsocket.MarketLevel();
            }
            input.ReadMessage(MarketLevel);
            break;
          }
          case 26: {
            if (optionGreeks_ == null) {
              OptionGreeks = new global::UpstoxWebsocket.OptionGreeks();
            }
            input.ReadMessage(OptionGreeks);
            break;
          }
          case 34: {
            if (marketOHLC_ == null) {
              MarketOHLC = new global::UpstoxWebsocket.MarketOHLC();
            }
            input.ReadMessage(MarketOHLC);
            break;
          }
          case 42: {
            if (eFeedDetails_ == null) {
              EFeedDetails = new global::UpstoxWebsocket.ExtendedFeedDetails();
            }
            input.ReadMessage(EFeedDetails);
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 10:
                    {
                        if (ltpc_ == null)
                        {
                            Ltpc = new global::UpstoxWebsocket.LTPC();
                        }
                        input.ReadMessage(Ltpc);
                        break;
                    }
                case 18:
                    {
                        if (marketLevel_ == null)
                        {
                            MarketLevel = new global::UpstoxWebsocket.MarketLevel();
                        }
                        input.ReadMessage(MarketLevel);
                        break;
                    }
                case 26:
                    {
                        if (optionGreeks_ == null)
                        {
                            OptionGreeks = new global::UpstoxWebsocket.OptionGreeks();
                        }
                        input.ReadMessage(OptionGreeks);
                        break;
                    }
                case 34:
                    {
                        if (marketOHLC_ == null)
                        {
                            MarketOHLC = new global::UpstoxWebsocket.MarketOHLC();
                        }
                        input.ReadMessage(MarketOHLC);
                        break;
                    }
                case 42:
                    {
                        if (eFeedDetails_ == null)
                        {
                            EFeedDetails = new global::UpstoxWebsocket.ExtendedFeedDetails();
                        }
                        input.ReadMessage(EFeedDetails);
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class IndexFullFeed : pb::IMessage<IndexFullFeed>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<IndexFullFeed> _parser = new pb::MessageParser<IndexFullFeed>(() => new IndexFullFeed());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IndexFullFeed> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[8]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IndexFullFeed()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IndexFullFeed(IndexFullFeed other) : this()
    {
        ltpc_ = other.ltpc_ != null ? other.ltpc_.Clone() : null;
        marketOHLC_ = other.marketOHLC_ != null ? other.marketOHLC_.Clone() : null;
        lastClose_ = other.lastClose_;
        yh_ = other.yh_;
        yl_ = other.yl_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IndexFullFeed Clone()
    {
        return new IndexFullFeed(this);
    }

    /// <summary>Field number for the "ltpc" field.</summary>
    public const int LtpcFieldNumber = 1;
    private global::UpstoxWebsocket.LTPC ltpc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.LTPC Ltpc
    {
        get { return ltpc_; }
        set
        {
            ltpc_ = value;
        }
    }

    /// <summary>Field number for the "marketOHLC" field.</summary>
    public const int MarketOHLCFieldNumber = 2;
    private global::UpstoxWebsocket.MarketOHLC marketOHLC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.MarketOHLC MarketOHLC
    {
        get { return marketOHLC_; }
        set
        {
            marketOHLC_ = value;
        }
    }

    /// <summary>Field number for the "lastClose" field.</summary>
    public const int LastCloseFieldNumber = 3;
    private double lastClose_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double LastClose
    {
        get { return lastClose_; }
        set
        {
            lastClose_ = value;
        }
    }

    /// <summary>Field number for the "yh" field.</summary>
    public const int YhFieldNumber = 4;
    private double yh_;
    /// <summary>
    ///yearly high
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Yh
    {
        get { return yh_; }
        set
        {
            yh_ = value;
        }
    }

    /// <summary>Field number for the "yl" field.</summary>
    public const int YlFieldNumber = 5;
    private double yl_;
    /// <summary>
    ///yearly low
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double Yl
    {
        get { return yl_; }
        set
        {
            yl_ = value;
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as IndexFullFeed);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IndexFullFeed other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!object.Equals(Ltpc, other.Ltpc)) return false;
        if (!object.Equals(MarketOHLC, other.MarketOHLC)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(LastClose, other.LastClose)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Yh, other.Yh)) return false;
        if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Yl, other.Yl)) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (ltpc_ != null) hash ^= Ltpc.GetHashCode();
        if (marketOHLC_ != null) hash ^= MarketOHLC.GetHashCode();
        if (LastClose != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(LastClose);
        if (Yh != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Yh);
        if (Yl != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Yl);
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (ltpc_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Ltpc);
      }
      if (marketOHLC_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MarketOHLC);
      }
      if (LastClose != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(LastClose);
      }
      if (Yh != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Yh);
      }
      if (Yl != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(Yl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (ltpc_ != null)
        {
            output.WriteRawTag(10);
            output.WriteMessage(Ltpc);
        }
        if (marketOHLC_ != null)
        {
            output.WriteRawTag(18);
            output.WriteMessage(MarketOHLC);
        }
        if (LastClose != 0D)
        {
            output.WriteRawTag(25);
            output.WriteDouble(LastClose);
        }
        if (Yh != 0D)
        {
            output.WriteRawTag(33);
            output.WriteDouble(Yh);
        }
        if (Yl != 0D)
        {
            output.WriteRawTag(41);
            output.WriteDouble(Yl);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (ltpc_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ltpc);
        }
        if (marketOHLC_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(MarketOHLC);
        }
        if (LastClose != 0D)
        {
            size += 1 + 8;
        }
        if (Yh != 0D)
        {
            size += 1 + 8;
        }
        if (Yl != 0D)
        {
            size += 1 + 8;
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IndexFullFeed other)
    {
        if (other == null)
        {
            return;
        }
        if (other.ltpc_ != null)
        {
            if (ltpc_ == null)
            {
                Ltpc = new global::UpstoxWebsocket.LTPC();
            }
            Ltpc.MergeFrom(other.Ltpc);
        }
        if (other.marketOHLC_ != null)
        {
            if (marketOHLC_ == null)
            {
                MarketOHLC = new global::UpstoxWebsocket.MarketOHLC();
            }
            MarketOHLC.MergeFrom(other.MarketOHLC);
        }
        if (other.LastClose != 0D)
        {
            LastClose = other.LastClose;
        }
        if (other.Yh != 0D)
        {
            Yh = other.Yh;
        }
        if (other.Yl != 0D)
        {
            Yl = other.Yl;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (ltpc_ == null) {
              Ltpc = new global::UpstoxWebsocket.LTPC();
            }
            input.ReadMessage(Ltpc);
            break;
          }
          case 18: {
            if (marketOHLC_ == null) {
              MarketOHLC = new global::UpstoxWebsocket.MarketOHLC();
            }
            input.ReadMessage(MarketOHLC);
            break;
          }
          case 25: {
            LastClose = input.ReadDouble();
            break;
          }
          case 33: {
            Yh = input.ReadDouble();
            break;
          }
          case 41: {
            Yl = input.ReadDouble();
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 10:
                    {
                        if (ltpc_ == null)
                        {
                            Ltpc = new global::UpstoxWebsocket.LTPC();
                        }
                        input.ReadMessage(Ltpc);
                        break;
                    }
                case 18:
                    {
                        if (marketOHLC_ == null)
                        {
                            MarketOHLC = new global::UpstoxWebsocket.MarketOHLC();
                        }
                        input.ReadMessage(MarketOHLC);
                        break;
                    }
                case 25:
                    {
                        LastClose = input.ReadDouble();
                        break;
                    }
                case 33:
                    {
                        Yh = input.ReadDouble();
                        break;
                    }
                case 41:
                    {
                        Yl = input.ReadDouble();
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class FullFeed : pb::IMessage<FullFeed>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<FullFeed> _parser = new pb::MessageParser<FullFeed>(() => new FullFeed());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FullFeed> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[9]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FullFeed()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FullFeed(FullFeed other) : this()
    {
        switch (other.FullFeedUnionCase)
        {
            case FullFeedUnionOneofCase.MarketFF:
                MarketFF = other.MarketFF.Clone();
                break;
            case FullFeedUnionOneofCase.IndexFF:
                IndexFF = other.IndexFF.Clone();
                break;
        }

        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FullFeed Clone()
    {
        return new FullFeed(this);
    }

    /// <summary>Field number for the "marketFF" field.</summary>
    public const int MarketFFFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.MarketFullFeed MarketFF
    {
        get { return fullFeedUnionCase_ == FullFeedUnionOneofCase.MarketFF ? (global::UpstoxWebsocket.MarketFullFeed)fullFeedUnion_ : null; }
        set
        {
            fullFeedUnion_ = value;
            fullFeedUnionCase_ = value == null ? FullFeedUnionOneofCase.None : FullFeedUnionOneofCase.MarketFF;
        }
    }

    /// <summary>Field number for the "indexFF" field.</summary>
    public const int IndexFFFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.IndexFullFeed IndexFF
    {
        get { return fullFeedUnionCase_ == FullFeedUnionOneofCase.IndexFF ? (global::UpstoxWebsocket.IndexFullFeed)fullFeedUnion_ : null; }
        set
        {
            fullFeedUnion_ = value;
            fullFeedUnionCase_ = value == null ? FullFeedUnionOneofCase.None : FullFeedUnionOneofCase.IndexFF;
        }
    }

    private object fullFeedUnion_;
    /// <summary>Enum of possible cases for the "FullFeedUnion" oneof.</summary>
    public enum FullFeedUnionOneofCase
    {
        None = 0,
        MarketFF = 1,
        IndexFF = 2,
    }
    private FullFeedUnionOneofCase fullFeedUnionCase_ = FullFeedUnionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FullFeedUnionOneofCase FullFeedUnionCase
    {
        get { return fullFeedUnionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFullFeedUnion()
    {
        fullFeedUnionCase_ = FullFeedUnionOneofCase.None;
        fullFeedUnion_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as FullFeed);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FullFeed other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!object.Equals(MarketFF, other.MarketFF)) return false;
        if (!object.Equals(IndexFF, other.IndexFF)) return false;
        if (FullFeedUnionCase != other.FullFeedUnionCase) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (fullFeedUnionCase_ == FullFeedUnionOneofCase.MarketFF) hash ^= MarketFF.GetHashCode();
        if (fullFeedUnionCase_ == FullFeedUnionOneofCase.IndexFF) hash ^= IndexFF.GetHashCode();
        hash ^= (int)fullFeedUnionCase_;
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (fullFeedUnionCase_ == FullFeedUnionOneofCase.MarketFF) {
        output.WriteRawTag(10);
        output.WriteMessage(MarketFF);
      }
      if (fullFeedUnionCase_ == FullFeedUnionOneofCase.IndexFF) {
        output.WriteRawTag(18);
        output.WriteMessage(IndexFF);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (fullFeedUnionCase_ == FullFeedUnionOneofCase.MarketFF)
        {
            output.WriteRawTag(10);
            output.WriteMessage(MarketFF);
        }
        if (fullFeedUnionCase_ == FullFeedUnionOneofCase.IndexFF)
        {
            output.WriteRawTag(18);
            output.WriteMessage(IndexFF);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (fullFeedUnionCase_ == FullFeedUnionOneofCase.MarketFF)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(MarketFF);
        }
        if (fullFeedUnionCase_ == FullFeedUnionOneofCase.IndexFF)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(IndexFF);
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FullFeed other)
    {
        if (other == null)
        {
            return;
        }
        switch (other.FullFeedUnionCase)
        {
            case FullFeedUnionOneofCase.MarketFF:
                if (MarketFF == null)
                {
                    MarketFF = new global::UpstoxWebsocket.MarketFullFeed();
                }
                MarketFF.MergeFrom(other.MarketFF);
                break;
            case FullFeedUnionOneofCase.IndexFF:
                if (IndexFF == null)
                {
                    IndexFF = new global::UpstoxWebsocket.IndexFullFeed();
                }
                IndexFF.MergeFrom(other.IndexFF);
                break;
        }

        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            global::UpstoxWebsocket.MarketFullFeed subBuilder = new global::UpstoxWebsocket.MarketFullFeed();
            if (fullFeedUnionCase_ == FullFeedUnionOneofCase.MarketFF) {
              subBuilder.MergeFrom(MarketFF);
            }
            input.ReadMessage(subBuilder);
            MarketFF = subBuilder;
            break;
          }
          case 18: {
            global::UpstoxWebsocket.IndexFullFeed subBuilder = new global::UpstoxWebsocket.IndexFullFeed();
            if (fullFeedUnionCase_ == FullFeedUnionOneofCase.IndexFF) {
              subBuilder.MergeFrom(IndexFF);
            }
            input.ReadMessage(subBuilder);
            IndexFF = subBuilder;
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 10:
                    {
                        global::UpstoxWebsocket.MarketFullFeed subBuilder = new global::UpstoxWebsocket.MarketFullFeed();
                        if (fullFeedUnionCase_ == FullFeedUnionOneofCase.MarketFF)
                        {
                            subBuilder.MergeFrom(MarketFF);
                        }
                        input.ReadMessage(subBuilder);
                        MarketFF = subBuilder;
                        break;
                    }
                case 18:
                    {
                        global::UpstoxWebsocket.IndexFullFeed subBuilder = new global::UpstoxWebsocket.IndexFullFeed();
                        if (fullFeedUnionCase_ == FullFeedUnionOneofCase.IndexFF)
                        {
                            subBuilder.MergeFrom(IndexFF);
                        }
                        input.ReadMessage(subBuilder);
                        IndexFF = subBuilder;
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class OptionChain : pb::IMessage<OptionChain>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<OptionChain> _parser = new pb::MessageParser<OptionChain>(() => new OptionChain());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OptionChain> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[10]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptionChain()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptionChain(OptionChain other) : this()
    {
        ltpc_ = other.ltpc_ != null ? other.ltpc_.Clone() : null;
        bidAskQuote_ = other.bidAskQuote_ != null ? other.bidAskQuote_.Clone() : null;
        optionGreeks_ = other.optionGreeks_ != null ? other.optionGreeks_.Clone() : null;
        eFeedDetails_ = other.eFeedDetails_ != null ? other.eFeedDetails_.Clone() : null;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OptionChain Clone()
    {
        return new OptionChain(this);
    }

    /// <summary>Field number for the "ltpc" field.</summary>
    public const int LtpcFieldNumber = 1;
    private global::UpstoxWebsocket.LTPC ltpc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.LTPC Ltpc
    {
        get { return ltpc_; }
        set
        {
            ltpc_ = value;
        }
    }

    /// <summary>Field number for the "bidAskQuote" field.</summary>
    public const int BidAskQuoteFieldNumber = 2;
    private global::UpstoxWebsocket.Quote bidAskQuote_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.Quote BidAskQuote
    {
        get { return bidAskQuote_; }
        set
        {
            bidAskQuote_ = value;
        }
    }

    /// <summary>Field number for the "optionGreeks" field.</summary>
    public const int OptionGreeksFieldNumber = 3;
    private global::UpstoxWebsocket.OptionGreeks optionGreeks_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.OptionGreeks OptionGreeks
    {
        get { return optionGreeks_; }
        set
        {
            optionGreeks_ = value;
        }
    }

    /// <summary>Field number for the "eFeedDetails" field.</summary>
    public const int EFeedDetailsFieldNumber = 4;
    private global::UpstoxWebsocket.ExtendedFeedDetails eFeedDetails_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.ExtendedFeedDetails EFeedDetails
    {
        get { return eFeedDetails_; }
        set
        {
            eFeedDetails_ = value;
        }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as OptionChain);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OptionChain other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!object.Equals(Ltpc, other.Ltpc)) return false;
        if (!object.Equals(BidAskQuote, other.BidAskQuote)) return false;
        if (!object.Equals(OptionGreeks, other.OptionGreeks)) return false;
        if (!object.Equals(EFeedDetails, other.EFeedDetails)) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (ltpc_ != null) hash ^= Ltpc.GetHashCode();
        if (bidAskQuote_ != null) hash ^= BidAskQuote.GetHashCode();
        if (optionGreeks_ != null) hash ^= OptionGreeks.GetHashCode();
        if (eFeedDetails_ != null) hash ^= EFeedDetails.GetHashCode();
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (ltpc_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Ltpc);
      }
      if (bidAskQuote_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(BidAskQuote);
      }
      if (optionGreeks_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OptionGreeks);
      }
      if (eFeedDetails_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(EFeedDetails);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (ltpc_ != null)
        {
            output.WriteRawTag(10);
            output.WriteMessage(Ltpc);
        }
        if (bidAskQuote_ != null)
        {
            output.WriteRawTag(18);
            output.WriteMessage(BidAskQuote);
        }
        if (optionGreeks_ != null)
        {
            output.WriteRawTag(26);
            output.WriteMessage(OptionGreeks);
        }
        if (eFeedDetails_ != null)
        {
            output.WriteRawTag(34);
            output.WriteMessage(EFeedDetails);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (ltpc_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ltpc);
        }
        if (bidAskQuote_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(BidAskQuote);
        }
        if (optionGreeks_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(OptionGreeks);
        }
        if (eFeedDetails_ != null)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(EFeedDetails);
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OptionChain other)
    {
        if (other == null)
        {
            return;
        }
        if (other.ltpc_ != null)
        {
            if (ltpc_ == null)
            {
                Ltpc = new global::UpstoxWebsocket.LTPC();
            }
            Ltpc.MergeFrom(other.Ltpc);
        }
        if (other.bidAskQuote_ != null)
        {
            if (bidAskQuote_ == null)
            {
                BidAskQuote = new global::UpstoxWebsocket.Quote();
            }
            BidAskQuote.MergeFrom(other.BidAskQuote);
        }
        if (other.optionGreeks_ != null)
        {
            if (optionGreeks_ == null)
            {
                OptionGreeks = new global::UpstoxWebsocket.OptionGreeks();
            }
            OptionGreeks.MergeFrom(other.OptionGreeks);
        }
        if (other.eFeedDetails_ != null)
        {
            if (eFeedDetails_ == null)
            {
                EFeedDetails = new global::UpstoxWebsocket.ExtendedFeedDetails();
            }
            EFeedDetails.MergeFrom(other.EFeedDetails);
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (ltpc_ == null) {
              Ltpc = new global::UpstoxWebsocket.LTPC();
            }
            input.ReadMessage(Ltpc);
            break;
          }
          case 18: {
            if (bidAskQuote_ == null) {
              BidAskQuote = new global::UpstoxWebsocket.Quote();
            }
            input.ReadMessage(BidAskQuote);
            break;
          }
          case 26: {
            if (optionGreeks_ == null) {
              OptionGreeks = new global::UpstoxWebsocket.OptionGreeks();
            }
            input.ReadMessage(OptionGreeks);
            break;
          }
          case 34: {
            if (eFeedDetails_ == null) {
              EFeedDetails = new global::UpstoxWebsocket.ExtendedFeedDetails();
            }
            input.ReadMessage(EFeedDetails);
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 10:
                    {
                        if (ltpc_ == null)
                        {
                            Ltpc = new global::UpstoxWebsocket.LTPC();
                        }
                        input.ReadMessage(Ltpc);
                        break;
                    }
                case 18:
                    {
                        if (bidAskQuote_ == null)
                        {
                            BidAskQuote = new global::UpstoxWebsocket.Quote();
                        }
                        input.ReadMessage(BidAskQuote);
                        break;
                    }
                case 26:
                    {
                        if (optionGreeks_ == null)
                        {
                            OptionGreeks = new global::UpstoxWebsocket.OptionGreeks();
                        }
                        input.ReadMessage(OptionGreeks);
                        break;
                    }
                case 34:
                    {
                        if (eFeedDetails_ == null)
                        {
                            EFeedDetails = new global::UpstoxWebsocket.ExtendedFeedDetails();
                        }
                        input.ReadMessage(EFeedDetails);
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class Feed : pb::IMessage<Feed>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<Feed> _parser = new pb::MessageParser<Feed>(() => new Feed());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Feed> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[11]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Feed()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Feed(Feed other) : this()
    {
        switch (other.FeedUnionCase)
        {
            case FeedUnionOneofCase.Ltpc:
                Ltpc = other.Ltpc.Clone();
                break;
            case FeedUnionOneofCase.Ff:
                Ff = other.Ff.Clone();
                break;
            case FeedUnionOneofCase.Oc:
                Oc = other.Oc.Clone();
                break;
        }

        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Feed Clone()
    {
        return new Feed(this);
    }

    /// <summary>Field number for the "ltpc" field.</summary>
    public const int LtpcFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.LTPC Ltpc
    {
        get { return feedUnionCase_ == FeedUnionOneofCase.Ltpc ? (global::UpstoxWebsocket.LTPC)feedUnion_ : null; }
        set
        {
            feedUnion_ = value;
            feedUnionCase_ = value == null ? FeedUnionOneofCase.None : FeedUnionOneofCase.Ltpc;
        }
    }

    /// <summary>Field number for the "ff" field.</summary>
    public const int FfFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.FullFeed Ff
    {
        get { return feedUnionCase_ == FeedUnionOneofCase.Ff ? (global::UpstoxWebsocket.FullFeed)feedUnion_ : null; }
        set
        {
            feedUnion_ = value;
            feedUnionCase_ = value == null ? FeedUnionOneofCase.None : FeedUnionOneofCase.Ff;
        }
    }

    /// <summary>Field number for the "oc" field.</summary>
    public const int OcFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.OptionChain Oc
    {
        get { return feedUnionCase_ == FeedUnionOneofCase.Oc ? (global::UpstoxWebsocket.OptionChain)feedUnion_ : null; }
        set
        {
            feedUnion_ = value;
            feedUnionCase_ = value == null ? FeedUnionOneofCase.None : FeedUnionOneofCase.Oc;
        }
    }

    private object feedUnion_;
    /// <summary>Enum of possible cases for the "FeedUnion" oneof.</summary>
    public enum FeedUnionOneofCase
    {
        None = 0,
        Ltpc = 1,
        Ff = 2,
        Oc = 3,
    }
    private FeedUnionOneofCase feedUnionCase_ = FeedUnionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedUnionOneofCase FeedUnionCase
    {
        get { return feedUnionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFeedUnion()
    {
        feedUnionCase_ = FeedUnionOneofCase.None;
        feedUnion_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as Feed);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Feed other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (!object.Equals(Ltpc, other.Ltpc)) return false;
        if (!object.Equals(Ff, other.Ff)) return false;
        if (!object.Equals(Oc, other.Oc)) return false;
        if (FeedUnionCase != other.FeedUnionCase) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (feedUnionCase_ == FeedUnionOneofCase.Ltpc) hash ^= Ltpc.GetHashCode();
        if (feedUnionCase_ == FeedUnionOneofCase.Ff) hash ^= Ff.GetHashCode();
        if (feedUnionCase_ == FeedUnionOneofCase.Oc) hash ^= Oc.GetHashCode();
        hash ^= (int)feedUnionCase_;
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (feedUnionCase_ == FeedUnionOneofCase.Ltpc) {
        output.WriteRawTag(10);
        output.WriteMessage(Ltpc);
      }
      if (feedUnionCase_ == FeedUnionOneofCase.Ff) {
        output.WriteRawTag(18);
        output.WriteMessage(Ff);
      }
      if (feedUnionCase_ == FeedUnionOneofCase.Oc) {
        output.WriteRawTag(26);
        output.WriteMessage(Oc);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (feedUnionCase_ == FeedUnionOneofCase.Ltpc)
        {
            output.WriteRawTag(10);
            output.WriteMessage(Ltpc);
        }
        if (feedUnionCase_ == FeedUnionOneofCase.Ff)
        {
            output.WriteRawTag(18);
            output.WriteMessage(Ff);
        }
        if (feedUnionCase_ == FeedUnionOneofCase.Oc)
        {
            output.WriteRawTag(26);
            output.WriteMessage(Oc);
        }
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (feedUnionCase_ == FeedUnionOneofCase.Ltpc)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ltpc);
        }
        if (feedUnionCase_ == FeedUnionOneofCase.Ff)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Ff);
        }
        if (feedUnionCase_ == FeedUnionOneofCase.Oc)
        {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Oc);
        }
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Feed other)
    {
        if (other == null)
        {
            return;
        }
        switch (other.FeedUnionCase)
        {
            case FeedUnionOneofCase.Ltpc:
                if (Ltpc == null)
                {
                    Ltpc = new global::UpstoxWebsocket.LTPC();
                }
                Ltpc.MergeFrom(other.Ltpc);
                break;
            case FeedUnionOneofCase.Ff:
                if (Ff == null)
                {
                    Ff = new global::UpstoxWebsocket.FullFeed();
                }
                Ff.MergeFrom(other.Ff);
                break;
            case FeedUnionOneofCase.Oc:
                if (Oc == null)
                {
                    Oc = new global::UpstoxWebsocket.OptionChain();
                }
                Oc.MergeFrom(other.Oc);
                break;
        }

        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            global::UpstoxWebsocket.LTPC subBuilder = new global::UpstoxWebsocket.LTPC();
            if (feedUnionCase_ == FeedUnionOneofCase.Ltpc) {
              subBuilder.MergeFrom(Ltpc);
            }
            input.ReadMessage(subBuilder);
            Ltpc = subBuilder;
            break;
          }
          case 18: {
            global::UpstoxWebsocket.FullFeed subBuilder = new global::UpstoxWebsocket.FullFeed();
            if (feedUnionCase_ == FeedUnionOneofCase.Ff) {
              subBuilder.MergeFrom(Ff);
            }
            input.ReadMessage(subBuilder);
            Ff = subBuilder;
            break;
          }
          case 26: {
            global::UpstoxWebsocket.OptionChain subBuilder = new global::UpstoxWebsocket.OptionChain();
            if (feedUnionCase_ == FeedUnionOneofCase.Oc) {
              subBuilder.MergeFrom(Oc);
            }
            input.ReadMessage(subBuilder);
            Oc = subBuilder;
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 10:
                    {
                        global::UpstoxWebsocket.LTPC subBuilder = new global::UpstoxWebsocket.LTPC();
                        if (feedUnionCase_ == FeedUnionOneofCase.Ltpc)
                        {
                            subBuilder.MergeFrom(Ltpc);
                        }
                        input.ReadMessage(subBuilder);
                        Ltpc = subBuilder;
                        break;
                    }
                case 18:
                    {
                        global::UpstoxWebsocket.FullFeed subBuilder = new global::UpstoxWebsocket.FullFeed();
                        if (feedUnionCase_ == FeedUnionOneofCase.Ff)
                        {
                            subBuilder.MergeFrom(Ff);
                        }
                        input.ReadMessage(subBuilder);
                        Ff = subBuilder;
                        break;
                    }
                case 26:
                    {
                        global::UpstoxWebsocket.OptionChain subBuilder = new global::UpstoxWebsocket.OptionChain();
                        if (feedUnionCase_ == FeedUnionOneofCase.Oc)
                        {
                            subBuilder.MergeFrom(Oc);
                        }
                        input.ReadMessage(subBuilder);
                        Oc = subBuilder;
                        break;
                    }
            }
        }
    }
#endif

}

[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class FeedResponse : pb::IMessage<FeedResponse>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
    private static readonly pb::MessageParser<FeedResponse> _parser = new pb::MessageParser<FeedResponse>(() => new FeedResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor
    {
        get { return global::UpstoxWebsocket.MarketDataFeed.Descriptor.MessageTypes[12]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor
    {
        get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedResponse()
    {
        OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedResponse(FeedResponse other) : this()
    {
        type_ = other.type_;
        feeds_ = other.feeds_.Clone();
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedResponse Clone()
    {
        return new FeedResponse(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::UpstoxWebsocket.Type type_ = global::UpstoxWebsocket.Type.InitialFeed;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::UpstoxWebsocket.Type Type
    {
        get { return type_; }
        set
        {
            type_ = value;
        }
    }

    /// <summary>Field number for the "feeds" field.</summary>
    public const int FeedsFieldNumber = 2;
    private static readonly pbc::MapField<string, global::UpstoxWebsocket.Feed>.Codec _map_feeds_codec
        = new pbc::MapField<string, global::UpstoxWebsocket.Feed>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::UpstoxWebsocket.Feed.Parser), 18);
    private readonly pbc::MapField<string, global::UpstoxWebsocket.Feed> feeds_ = new pbc::MapField<string, global::UpstoxWebsocket.Feed>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::UpstoxWebsocket.Feed> Feeds
    {
        get { return feeds_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other)
    {
        return Equals(other as FeedResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedResponse other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }
        if (ReferenceEquals(other, this))
        {
            return true;
        }
        if (Type != other.Type) return false;
        if (!Feeds.Equals(other.Feeds)) return false;
        return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode()
    {
        int hash = 1;
        if (Type != global::UpstoxWebsocket.Type.InitialFeed) hash ^= Type.GetHashCode();
        hash ^= Feeds.GetHashCode();
        if (_unknownFields != null)
        {
            hash ^= _unknownFields.GetHashCode();
        }
        return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString()
    {
        return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
#else
      if (Type != global::UpstoxWebsocket.Type.InitialFeed) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      feeds_.WriteTo(output, _map_feeds_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output)
    {
        if (Type != global::UpstoxWebsocket.Type.InitialFeed)
        {
            output.WriteRawTag(8);
            output.WriteEnum((int)Type);
        }
        feeds_.WriteTo(ref output, _map_feeds_codec);
        if (_unknownFields != null)
        {
            _unknownFields.WriteTo(ref output);
        }
    }
#endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize()
    {
        int size = 0;
        if (Type != global::UpstoxWebsocket.Type.InitialFeed)
        {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Type);
        }
        size += feeds_.CalculateSize(_map_feeds_codec);
        if (_unknownFields != null)
        {
            size += _unknownFields.CalculateSize();
        }
        return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeedResponse other)
    {
        if (other == null)
        {
            return;
        }
        if (other.Type != global::UpstoxWebsocket.Type.InitialFeed)
        {
            Type = other.Type;
        }
        feeds_.MergeFrom(other.feeds_);
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input)
    {
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
#else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Type = (global::UpstoxWebsocket.Type) input.ReadEnum();
            break;
          }
          case 18: {
            feeds_.AddEntriesFrom(input, _map_feeds_codec);
            break;
          }
        }
      }
#endif
    }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input)
    {
        uint tag;
        while ((tag = input.ReadTag()) != 0)
        {
            switch (tag)
            {
                default:
                    _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                    break;
                case 8:
                    {
                        Type = (global::UpstoxWebsocket.Type)input.ReadEnum();
                        break;
                    }
                case 18:
                    {
                        feeds_.AddEntriesFrom(ref input, _map_feeds_codec);
                        break;
                    }
            }
        }
    }
#endif

}

#endregion

