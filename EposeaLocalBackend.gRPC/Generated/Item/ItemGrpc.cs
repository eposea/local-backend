// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: item.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace EposeaLocalBackend.gRPC.Proto.Item {
  public static partial class ItemService
  {
    static readonly string __ServiceName = "eposea.item.ItemService";

    static readonly grpc::Marshaller<global::EposeaLocalBackend.gRPC.Proto.Item.GetItemRequest> __Marshaller_eposea_item_GetItemRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EposeaLocalBackend.gRPC.Proto.Item.GetItemRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::EposeaLocalBackend.gRPC.Proto.Item.Item> __Marshaller_eposea_item_Item = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::EposeaLocalBackend.gRPC.Proto.Item.Item.Parser.ParseFrom);

    static readonly grpc::Method<global::EposeaLocalBackend.gRPC.Proto.Item.GetItemRequest, global::EposeaLocalBackend.gRPC.Proto.Item.Item> __Method_GetItem = new grpc::Method<global::EposeaLocalBackend.gRPC.Proto.Item.GetItemRequest, global::EposeaLocalBackend.gRPC.Proto.Item.Item>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetItem",
        __Marshaller_eposea_item_GetItemRequest,
        __Marshaller_eposea_item_Item);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::EposeaLocalBackend.gRPC.Proto.Item.ItemReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ItemService</summary>
    [grpc::BindServiceMethod(typeof(ItemService), "BindService")]
    public abstract partial class ItemServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::EposeaLocalBackend.gRPC.Proto.Item.Item> GetItem(global::EposeaLocalBackend.gRPC.Proto.Item.GetItemRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ItemServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetItem, serviceImpl.GetItem).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ItemServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetItem, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::EposeaLocalBackend.gRPC.Proto.Item.GetItemRequest, global::EposeaLocalBackend.gRPC.Proto.Item.Item>(serviceImpl.GetItem));
    }

  }
}
#endregion