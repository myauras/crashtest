using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"Realm",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// MongoDB.Bson.Serialization.IBsonSerializer<System.DateTimeOffset>
	// MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<System.DateTimeOffset>>
	// MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<byte>>
	// MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<int>>
	// MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<long>>
	// MongoDB.Bson.Serialization.IBsonSerializer<double>
	// MongoDB.Bson.Serialization.IBsonSerializer<int>
	// MongoDB.Bson.Serialization.IBsonSerializer<object>
	// Realms.CollectionExtensions.<>c__19<double>
	// Realms.CollectionExtensions.<>c__19<int>
	// Realms.IRealmCollection<double>
	// Realms.IRealmCollection<int>
	// Realms.MarshaledVector.<ToEnumerable>d__7<Realms.NotifiableObjectHandleBase.CollectionChangeSet.Move>
	// Realms.MarshaledVector.<ToEnumerable>d__7<System.IntPtr>
	// Realms.MarshaledVector.Enumerator<Realms.NotifiableObjectHandleBase.CollectionChangeSet.Move>
	// Realms.MarshaledVector.Enumerator<System.IntPtr>
	// Realms.MarshaledVector<Realms.NotifiableObjectHandleBase.CollectionChangeSet.Move>
	// Realms.MarshaledVector<System.IntPtr>
	// Realms.Native.Arena.Buffer<Realms.NotifiableObjectHandleBase.CollectionChangeSet.Move>
	// Realms.Native.Arena.Buffer<System.IntPtr>
	// Realms.NotificationCallbackDelegate<double>
	// Realms.NotificationCallbackDelegate<int>
	// Realms.NotificationCallbacks.<>c<double>
	// Realms.NotificationCallbacks.<>c<int>
	// Realms.NotificationCallbacks.<>c__DisplayClass3_0<double>
	// Realms.NotificationCallbacks.<>c__DisplayClass3_0<int>
	// Realms.NotificationCallbacks<double>
	// Realms.NotificationCallbacks<int>
	// Realms.RealmCollectionBase.<>c<double>
	// Realms.RealmCollectionBase.<>c<int>
	// Realms.RealmCollectionBase.<>c__DisplayClass43_0<double>
	// Realms.RealmCollectionBase.<>c__DisplayClass43_0<int>
	// Realms.RealmCollectionBase.<>c__DisplayClass43_1<double>
	// Realms.RealmCollectionBase.<>c__DisplayClass43_1<int>
	// Realms.RealmCollectionBase.<>c__DisplayClass49_0<double>
	// Realms.RealmCollectionBase.<>c__DisplayClass49_0<int>
	// Realms.RealmCollectionBase.Enumerator<double>
	// Realms.RealmCollectionBase.Enumerator<int>
	// Realms.RealmCollectionBase<double>
	// Realms.RealmCollectionBase<int>
	// Realms.RealmList<double>
	// Realms.RealmList<int>
	// Realms.RealmResults<double>
	// Realms.RealmResults<int>
	// System.Action<double>
	// System.Action<int>
	// System.Action<object,MongoDB.Bson.Serialization.BsonSerializationArgs,object>
	// System.Action<object>
	// System.Collections.Concurrent.ConcurrentDictionary.<GetEnumerator>d__35<object,object>
	// System.Collections.Concurrent.ConcurrentDictionary.DictionaryEnumerator<object,object>
	// System.Collections.Concurrent.ConcurrentDictionary.Node<object,object>
	// System.Collections.Concurrent.ConcurrentDictionary.Tables<object,object>
	// System.Collections.Concurrent.ConcurrentDictionary<object,object>
	// System.Collections.Generic.ArraySortHelper<double>
	// System.Collections.Generic.ArraySortHelper<int>
	// System.Collections.Generic.ArraySortHelper<object>
	// System.Collections.Generic.Comparer<byte>
	// System.Collections.Generic.Comparer<double>
	// System.Collections.Generic.Comparer<int>
	// System.Collections.Generic.Comparer<object>
	// System.Collections.Generic.Dictionary.Enumerator<int,System.ValueTuple<object,byte,object>>
	// System.Collections.Generic.Dictionary.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,System.ValueTuple<object,byte,object>>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection<int,System.ValueTuple<object,byte,object>>
	// System.Collections.Generic.Dictionary.KeyCollection<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,System.ValueTuple<object,byte,object>>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection<int,System.ValueTuple<object,byte,object>>
	// System.Collections.Generic.Dictionary.ValueCollection<object,object>
	// System.Collections.Generic.Dictionary<int,System.ValueTuple<object,byte,object>>
	// System.Collections.Generic.Dictionary<object,object>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<object,byte,object>>
	// System.Collections.Generic.EqualityComparer<byte>
	// System.Collections.Generic.EqualityComparer<int>
	// System.Collections.Generic.EqualityComparer<object>
	// System.Collections.Generic.ICollection<Realms.Schema.Property>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,System.ValueTuple<object,byte,object>>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,Realms.Schema.Property>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.ICollection<double>
	// System.Collections.Generic.ICollection<int>
	// System.Collections.Generic.ICollection<object>
	// System.Collections.Generic.IComparer<double>
	// System.Collections.Generic.IComparer<int>
	// System.Collections.Generic.IComparer<object>
	// System.Collections.Generic.IDictionary<object,Realms.Schema.Property>
	// System.Collections.Generic.IDictionary<object,object>
	// System.Collections.Generic.IEnumerable<Realms.ChangeSet.Move>
	// System.Collections.Generic.IEnumerable<Realms.NotifiableObjectHandleBase.CollectionChangeSet.Move>
	// System.Collections.Generic.IEnumerable<Realms.Schema.Property>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,System.ValueTuple<object,byte,object>>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,Realms.Schema.Property>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<System.IntPtr>
	// System.Collections.Generic.IEnumerable<double>
	// System.Collections.Generic.IEnumerable<int>
	// System.Collections.Generic.IEnumerable<object>
	// System.Collections.Generic.IEnumerator<Realms.ChangeSet.Move>
	// System.Collections.Generic.IEnumerator<Realms.NotifiableObjectHandleBase.CollectionChangeSet.Move>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,System.ValueTuple<object,byte,object>>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,Realms.Schema.Property>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerator<System.IntPtr>
	// System.Collections.Generic.IEnumerator<double>
	// System.Collections.Generic.IEnumerator<int>
	// System.Collections.Generic.IEnumerator<object>
	// System.Collections.Generic.IEqualityComparer<int>
	// System.Collections.Generic.IEqualityComparer<object>
	// System.Collections.Generic.IList<double>
	// System.Collections.Generic.IList<int>
	// System.Collections.Generic.IList<object>
	// System.Collections.Generic.IReadOnlyCollection<Realms.NotifiableObjectHandleBase.CollectionChangeSet.Move>
	// System.Collections.Generic.IReadOnlyCollection<System.IntPtr>
	// System.Collections.Generic.IReadOnlyDictionary<object,System.IntPtr>
	// System.Collections.Generic.IReadOnlyList<double>
	// System.Collections.Generic.IReadOnlyList<int>
	// System.Collections.Generic.KeyValuePair<int,System.ValueTuple<object,byte,object>>
	// System.Collections.Generic.KeyValuePair<object,Realms.Schema.Property>
	// System.Collections.Generic.KeyValuePair<object,object>
	// System.Collections.Generic.List.Enumerator<double>
	// System.Collections.Generic.List.Enumerator<int>
	// System.Collections.Generic.List.Enumerator<object>
	// System.Collections.Generic.List<double>
	// System.Collections.Generic.List<int>
	// System.Collections.Generic.List<object>
	// System.Collections.Generic.ObjectComparer<byte>
	// System.Collections.Generic.ObjectComparer<double>
	// System.Collections.Generic.ObjectComparer<int>
	// System.Collections.Generic.ObjectComparer<object>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<object,byte,object>>
	// System.Collections.Generic.ObjectEqualityComparer<byte>
	// System.Collections.Generic.ObjectEqualityComparer<int>
	// System.Collections.Generic.ObjectEqualityComparer<object>
	// System.Collections.ObjectModel.ReadOnlyCollection<double>
	// System.Collections.ObjectModel.ReadOnlyCollection<int>
	// System.Collections.ObjectModel.ReadOnlyCollection<object>
	// System.Collections.ObjectModel.ReadOnlyDictionary.DictionaryEnumerator<object,Realms.Schema.Property>
	// System.Collections.ObjectModel.ReadOnlyDictionary.KeyCollection<object,Realms.Schema.Property>
	// System.Collections.ObjectModel.ReadOnlyDictionary.ValueCollection<object,Realms.Schema.Property>
	// System.Collections.ObjectModel.ReadOnlyDictionary<object,Realms.Schema.Property>
	// System.Comparison<double>
	// System.Comparison<int>
	// System.Comparison<object>
	// System.Func<Realms.ChangeSet.Move,int>
	// System.Func<Realms.NotifiableObjectHandleBase.CollectionChangeSet.Move,Realms.ChangeSet.Move>
	// System.Func<System.IntPtr,int>
	// System.Func<System.ValueTuple<object,byte,object>,object>
	// System.Func<double,object>
	// System.Func<int,double>
	// System.Func<int,int>
	// System.Func<int,object>
	// System.Func<object,object>
	// System.Func<object>
	// System.Lazy<object>
	// System.Nullable<Realms.NotifiableObjectHandleBase.CollectionChangeSet>
	// System.Nullable<Realms.RealmValue.HandlesToCleanup>
	// System.Nullable<Realms.Schema.Property>
	// System.Nullable<byte>
	// System.Nullable<int>
	// System.Nullable<long>
	// System.Predicate<double>
	// System.Predicate<int>
	// System.Predicate<object>
	// System.ValueTuple<object,byte,object>
	// }}

	public void RefMethods()
	{
		// MongoDB.Bson.Serialization.IBsonSerializer<System.DateTimeOffset> MongoDB.Bson.Serialization.BsonSerializer.LookupSerializer<System.DateTimeOffset>()
		// MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<System.DateTimeOffset>> MongoDB.Bson.Serialization.BsonSerializer.LookupSerializer<System.Nullable<System.DateTimeOffset>>()
		// MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<byte>> MongoDB.Bson.Serialization.BsonSerializer.LookupSerializer<System.Nullable<byte>>()
		// MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<int>> MongoDB.Bson.Serialization.BsonSerializer.LookupSerializer<System.Nullable<int>>()
		// MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<long>> MongoDB.Bson.Serialization.BsonSerializer.LookupSerializer<System.Nullable<long>>()
		// MongoDB.Bson.Serialization.IBsonSerializer<double> MongoDB.Bson.Serialization.BsonSerializer.LookupSerializer<double>()
		// MongoDB.Bson.Serialization.IBsonSerializer<int> MongoDB.Bson.Serialization.BsonSerializer.LookupSerializer<int>()
		// MongoDB.Bson.Serialization.IBsonSerializer<object> MongoDB.Bson.Serialization.BsonSerializer.LookupSerializer<object>()
		// System.DateTimeOffset MongoDB.Bson.Serialization.IBsonSerializerExtensions.Deserialize<System.DateTimeOffset>(MongoDB.Bson.Serialization.IBsonSerializer<System.DateTimeOffset>,MongoDB.Bson.Serialization.BsonDeserializationContext)
		// System.Nullable<System.DateTimeOffset> MongoDB.Bson.Serialization.IBsonSerializerExtensions.Deserialize<System.Nullable<System.DateTimeOffset>>(MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<System.DateTimeOffset>>,MongoDB.Bson.Serialization.BsonDeserializationContext)
		// System.Nullable<byte> MongoDB.Bson.Serialization.IBsonSerializerExtensions.Deserialize<System.Nullable<byte>>(MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<byte>>,MongoDB.Bson.Serialization.BsonDeserializationContext)
		// System.Nullable<int> MongoDB.Bson.Serialization.IBsonSerializerExtensions.Deserialize<System.Nullable<int>>(MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<int>>,MongoDB.Bson.Serialization.BsonDeserializationContext)
		// System.Nullable<long> MongoDB.Bson.Serialization.IBsonSerializerExtensions.Deserialize<System.Nullable<long>>(MongoDB.Bson.Serialization.IBsonSerializer<System.Nullable<long>>,MongoDB.Bson.Serialization.BsonDeserializationContext)
		// double MongoDB.Bson.Serialization.IBsonSerializerExtensions.Deserialize<double>(MongoDB.Bson.Serialization.IBsonSerializer<double>,MongoDB.Bson.Serialization.BsonDeserializationContext)
		// int MongoDB.Bson.Serialization.IBsonSerializerExtensions.Deserialize<int>(MongoDB.Bson.Serialization.IBsonSerializer<int>,MongoDB.Bson.Serialization.BsonDeserializationContext)
		// object MongoDB.Bson.Serialization.IBsonSerializerExtensions.Deserialize<object>(MongoDB.Bson.Serialization.IBsonSerializer<object>,MongoDB.Bson.Serialization.BsonDeserializationContext)
		// System.Void Realms.CollectionExtensions.PopulateCollection<double>(System.Collections.Generic.ICollection<double>,System.Collections.Generic.ICollection<double>,bool,bool)
		// System.Void Realms.CollectionExtensions.PopulateCollection<int>(System.Collections.Generic.ICollection<int>,System.Collections.Generic.ICollection<int>,bool,bool)
		// System.Void Realms.CollectionExtensions.PopulateCollectionCore<double>(System.Collections.Generic.ICollection<double>,System.Collections.Generic.ICollection<double>,bool,bool,System.Func<double,object>)
		// System.Void Realms.CollectionExtensions.PopulateCollectionCore<int>(System.Collections.Generic.ICollection<int>,System.Collections.Generic.ICollection<int>,bool,bool,System.Func<int,object>)
		// System.Collections.Generic.IList<double> Realms.ManagedAccessor.GetListValue<double>(string)
		// System.Collections.Generic.IList<int> Realms.ManagedAccessor.GetListValue<int>(string)
		// Realms.RealmList<double> Realms.ObjectHandle.GetList<double>(Realms.Realm,string,Realms.Metadata,string)
		// Realms.RealmList<int> Realms.ObjectHandle.GetList<int>(Realms.Realm,string,Realms.Metadata,string)
		// object Realms.Realm.Add<object>(object,bool)
		// System.Void Realms.Realm.AddInternal<object>(object,System.Type,bool)
		// object Realms.RealmValue.AsRealmObject<object>()
		// System.Void Realms.Serialization.RealmObjectSerializerBase<object>.WriteArray<double>(MongoDB.Bson.Serialization.BsonSerializationContext,MongoDB.Bson.Serialization.BsonSerializationArgs,string,System.Collections.Generic.IEnumerable<double>)
		// System.Void Realms.Serialization.RealmObjectSerializerBase<object>.WriteArray<int>(MongoDB.Bson.Serialization.BsonSerializationContext,MongoDB.Bson.Serialization.BsonSerializationArgs,string,System.Collections.Generic.IEnumerable<int>)
		// System.Void Realms.Serialization.RealmObjectSerializerBase<object>.WriteList<double>(MongoDB.Bson.Serialization.BsonSerializationContext,MongoDB.Bson.Serialization.BsonSerializationArgs,string,System.Collections.Generic.IEnumerable<double>)
		// System.Void Realms.Serialization.RealmObjectSerializerBase<object>.WriteList<int>(MongoDB.Bson.Serialization.BsonSerializationContext,MongoDB.Bson.Serialization.BsonSerializationArgs,string,System.Collections.Generic.IEnumerable<int>)
		// System.Void Realms.Serialization.RealmObjectSerializerBase<object>.WriteValue<System.DateTimeOffset>(MongoDB.Bson.Serialization.BsonSerializationContext,MongoDB.Bson.Serialization.BsonSerializationArgs,string,System.DateTimeOffset)
		// System.Void Realms.Serialization.RealmObjectSerializerBase<object>.WriteValue<System.Nullable<System.DateTimeOffset>>(MongoDB.Bson.Serialization.BsonSerializationContext,MongoDB.Bson.Serialization.BsonSerializationArgs,string,System.Nullable<System.DateTimeOffset>)
		// System.Void Realms.Serialization.RealmObjectSerializerBase<object>.WriteValue<System.Nullable<byte>>(MongoDB.Bson.Serialization.BsonSerializationContext,MongoDB.Bson.Serialization.BsonSerializationArgs,string,System.Nullable<byte>)
		// System.Void Realms.Serialization.RealmObjectSerializerBase<object>.WriteValue<System.Nullable<int>>(MongoDB.Bson.Serialization.BsonSerializationContext,MongoDB.Bson.Serialization.BsonSerializationArgs,string,System.Nullable<int>)
		// System.Void Realms.Serialization.RealmObjectSerializerBase<object>.WriteValue<System.Nullable<long>>(MongoDB.Bson.Serialization.BsonSerializationContext,MongoDB.Bson.Serialization.BsonSerializationArgs,string,System.Nullable<long>)
		// System.Void Realms.Serialization.RealmObjectSerializerBase<object>.WriteValue<object>(MongoDB.Bson.Serialization.BsonSerializationContext,MongoDB.Bson.Serialization.BsonSerializationArgs,string,object)
		// object& System.Runtime.CompilerServices.Unsafe.As<object,object>(object&)
		// System.Void* System.Runtime.CompilerServices.Unsafe.AsPointer<object>(object&)
	}
}