﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.42
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------




<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0"), _
System.ServiceModel.ServiceContractAttribute(Namespace:="http://microsoft.wcf.documentation", _
ConfigurationName:="IBehaviorService", SessionMode:=System.ServiceModel.SessionMode.Required)> _
Public Interface IBehaviorService

    <System.ServiceModel.OperationContractAttribute(Action:="http://microsoft.wcf.documentation/IBehaviorService/TxWork", _
            ReplyAction:="http://microsoft.wcf.documentation/IBehaviorService/TxWorkResponse"), _
            System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Mandatory)> _
    Function TxWork(ByVal message As String) As String
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Public Interface IBehaviorServiceChannel
	Inherits IBehaviorService, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")> _
Partial Public Class BehaviorServiceClient
	Inherits System.ServiceModel.ClientBase(Of IBehaviorService)
	Implements IBehaviorService

	Public Sub New()
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String)
		MyBase.New(endpointConfigurationName)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(endpointConfigurationName, remoteAddress)
	End Sub

	Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
		MyBase.New(binding, remoteAddress)
	End Sub

	Public Function TxWork(ByVal message As String) As String Implements IBehaviorService.TxWork
		Return MyBase.Channel.TxWork(message)
	End Function
End Class
