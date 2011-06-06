using System;
using System.Collections.Generic;
using System.ServiceModel;
using MefContrib.Hosting.Isolation.Runtime.Activation;

namespace MefContrib.Hosting.Isolation.Runtime
{
    /// <summary>
    /// remote activator
    /// </summary>
    [ServiceContract]
    public interface IRemoteActivator
    {
        [OperationContract]
        void HeartBeat();

        [OperationContract]
        ObjectReference ActivateInstance(ActivationHostDescription description, string assembly, string type);

        [OperationContract]
        object InvokeMember(ObjectReference objectReference, string name, List<RuntimeArgument> arguments);

        [OperationContract]
        void DeactivateInstance(ObjectReference objectReference);
    }
}