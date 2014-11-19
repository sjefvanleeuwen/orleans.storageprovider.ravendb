//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Orleans.StorageProvider.RavenDB.TestGrains
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Runtime.Serialization;
    using Orleans.StorageProvider.RavenDB.TestInterfaces;
    using Orleans;
    using Orleans.Runtime;
    using Orleans.CodeGeneration;
    using System.Runtime.InteropServices;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Orleans.StorageProvider.RavenDB.TestGrains.Orleans.StorageProvider.RavenDB.TestGr" +
        "ains.Email")]
    public class EmailState : global::Orleans.CodeGeneration.GrainState, IEmailState
    {
        

            public String Email { get; set; }

            public Nullable<DateTimeOffset> SentAt { get; set; }

            public IPerson Person { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("Email", out value)) Email = (String) value;
                if (values.TryGetValue("SentAt", out value)) SentAt = (Nullable<DateTimeOffset>) value;
                if (values.TryGetValue("Person", out value)) Person = (IPerson) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("EmailState( Email={0} SentAt={1} Person={2} )", Email, SentAt, Person);
            }
        
        public EmailState() : 
                base("Orleans.StorageProvider.RavenDB.TestGrains.Email")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["Email"] = this.Email;
            result["SentAt"] = this.SentAt;
            result["Person"] = this.Person;
            return result;
        }
        
        private void InitStateFields()
        {
            this.Email = default(String);
            this.SentAt = default(Nullable<DateTimeOffset>);
            this.Person = default(IPerson);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            EmailState input = ((EmailState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            EmailState input = ((EmailState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            EmailState result = new EmailState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Orleans.StorageProvider.RavenDB.TestGrains.Orleans.StorageProvider.RavenDB.TestGr" +
        "ains.Person")]
    public class PersonState : global::Orleans.CodeGeneration.GrainState, IPersonState
    {
        

            public String FirstName { get; set; }

            public String LastName { get; set; }

            public GenderType Gender { get; set; }

            public Int32 Age { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("FirstName", out value)) FirstName = (String) value;
                if (values.TryGetValue("LastName", out value)) LastName = (String) value;
                if (values.TryGetValue("Gender", out value)) Gender = (GenderType) value;
                if (values.TryGetValue("Age", out value)) Age = value is Int64 ? (Int32)(Int64)value : (Int32)value;
            }

            public override System.String ToString()
            {
                return System.String.Format("PersonState( FirstName={0} LastName={1} Gender={2} Age={3} )", FirstName, LastName, Gender, Age);
            }
        
        public PersonState() : 
                base("Orleans.StorageProvider.RavenDB.TestGrains.Person")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["FirstName"] = this.FirstName;
            result["LastName"] = this.LastName;
            result["Gender"] = this.Gender;
            result["Age"] = this.Age;
            return result;
        }
        
        private void InitStateFields()
        {
            this.FirstName = default(String);
            this.LastName = default(String);
            this.Gender = default(GenderType);
            this.Age = default(Int32);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            PersonState input = ((PersonState)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            PersonState input = ((PersonState)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            PersonState result = new PersonState();
            result.DeserializeFrom(stream);
            return result;
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
