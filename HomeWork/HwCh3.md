ISTA-422 HomeWork Chapter 3

Rory Millington

05 May 2018

1. What is Azure Virtual Machines and the terminology used in the chapter to reference?

	The terminology used to describe the Azure Virtual Machines feature and a virtual machine instance can be a little confusing. Therefore, throughout this chapter, Azure Virtual Machines will refer to the feature, while virtual machine or VM will refer to an instance of an actual compute node. 


2. How do you stop an Azure VM, and give an example?

	To stop a VM but keep it provisioned, you would need to use the Stop-AzureRmVM PowerShell cmdlet such as in the following example:
 
	Stop-AzureRmVM -Name "AzEssentialDev3" -ResourceGroup "AzureEssentials" -StayProvisioned 
	For classic VMs, a similar cmdlet, Stop-AzureVM, would be used. When using the Azure CLI, there are two commands used to control the stopped state of a VM: azure vm stop and azure vm deallocate. 


3. What are three main resource providers used when working with Azure Vitrual Machines, Storage, and Compute?

	The Network resource provider (Microsoft.Network) handles all aspects of network connectivity such as IP addresses, load balancers, NICs, and so on.  The Storage resource provider (Microsoft.Storage) handles the storage of the disks for a VM (in the context of Azure Virtual Machines).  The Compute resource provider (Microsoft.Compute) handles details related to the VM itself, such as naming, operating system details, and configuration (size, number of disks, and so on). 

4. Where are durable disks stored and what are the beneﬁts?

	All durable disks (the OS disk and data disks) are backed by page blobs in Azure Storage. Therefore, the disks inherit the benefits of blob storage: high availability, durability, and geo-redundancy options. Blob storage provides a mechanism by which data can be stored safely for use by the VM. The disks can be mounted as drives on the VM. The Azure platform will hold an infinite lease on the page blob to prevent accidental deletion of the page blob containing the VHD, the related container, or the storage account. 

5. What is required when creating a VM in Azure using the Resource Manager model?

	When creating a VM in Azure using the Resource Manager model, it is required that the VM be placed within an Azure Virtual Network (VNET). You will decide to use an existing VNET (or create a new one), the subnet to use, the IP address, if there is a load balancer or not, the number of NICs, and how network security is handled, as depicted in Figure 3-2. While it may seem like a lot just to get a VM deployed, these are important aspects to consider for the accessibility and security of the VM. 	


6. What is a NIC and what does it what does it do for Azure?

	A network interface card (NIC) provides network access to resources in an Azure virtual network. A NIC is a standalone resource, but it must be associated with a VM to provide network access (a NIC by itself is of little value). The maximum number of NICs attached to a VM is dependent on the size of the selected VM. 

7. Why should you deploy at least two instances of the VM? What is provided?

	To avoid a single point of failure, it is recommended to deploy at least two instances of the VM. In fact, Azure provides an SLA only when two or more VMs are deployed into an availability set. This is a logical feature used to ensure that a group of related VMs are deployed so that they are not all subject to a single point of failure and not all upgraded at the same time during a host operating system upgrade in the datacenter. The first two VMs deployed in an availability set are allocated to two different fault domains, ensuring that a single point of failure will not affect them both simultaneously. Similarly, the first five VMs deployed in an availability set are allocated to five different update domains, minimizing the impact when the Azure platform induces host operating system updates one update domain at a time. VMs placed in an availability set should perform an identical set of functionalities. 

8. How many ways can you connect to your VM, and what are they?

	Connectivity can be done by remotely accessing (for example, logging in remotely to) the VM for an interactive session or by configuring network access to allow other programs or services to communicate with the VM. 


9. Who’s responsibility is it to manage the VM?

	The overall management of the VMs is largely the user’s responsibility—you can do pretty much whatever you desire on the VM. Configuration and management of the VM can be done via numerous methods, such as manually via a Remote Desktop connection, remotely using PowerShell or PowerShell DSC (desired state configuration), or VM extensions for popular tools like Chef and Puppet. There is a wide range of choices for configuring the VM—the choice is yours.

10. What is important when determining the scale-out approach to VMs, and what model is this referred to?

	As with most Azure services, Azure Virtual Machines follow a scale out, not scale up, model. This means it is preferable to deploy more instances of the same configuration than to add larger, more powerful machines. The approach for scaling out VMs varies depending on whether you’re working with classic VMs or Resource Manager VMs. 
