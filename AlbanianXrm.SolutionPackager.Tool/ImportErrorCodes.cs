namespace AlbanianXrm.SolutionPackager
{
    public enum ImportErrorCodes : int
	{

		/// <summary>
		/// There was an error in parsing the article templates in Import Xml
		/// </summary>
		ImportArticleTemplateError = -2147188723,

		/// <summary>
		/// Invalid name for attribute {0}.  Custom attribute names must start with a valid customization prefix. The prefix for a solution component should match the prefix that is specified for the publisher of the solution.
		/// </summary>
		ImportAttributeNameError = -2147188638,

		/// <summary>
		/// An error occurred while importing Channel Property Group.
		/// </summary>
		ImportChannelPropertyGroupError = -2147088141,

		/// <summary>
		/// You cannot update this component because it does not exist in this Microsoft Dynamics 365 organization.
		/// </summary>
		ImportComponentDeletedIgnored = -2147187588,

		/// <summary>
		/// Cannot process with Bulk Import as Import Configuration not specified.
		/// </summary>
		ImportConfigNotSpecified = -2147220702,

		/// <summary>
		/// There was an error in parsing the contract templates in Import Xml
		/// </summary>
		ImportContractTemplateError = -2147188725,

		/// <summary>
		/// An error occurred while importing Convert Rules.
		/// </summary>
		ImportConvertRuleError = -2147157911,

		/// <summary>
		/// The solution file is invalid. The compressed file must contain the following files at its root: solution.xml, customizations.xml, and [Content_Types].xml. Customization files exported from previous versions of Microsoft Dynamics 365 are not supported.
		/// </summary>
		ImportCustomizationsBadZipFileError = -2147188640,

		/// <summary>
		/// A dashboard with the same id is marked as deleted in the system. Please first publish the system form entity and import again.
		/// </summary>
		ImportDashboardDeletedError = -2147163384,

		/// <summary>
		/// The package supplied for the default solution is trying to install it in managed mode. The default solution cannot be managed. In the XML for the default solution, set the Managed value back to "false" and try to import the solution again.
		/// </summary>
		ImportDefaultAsPackageError = -2147188663,

		/// <summary>
		/// {0} requires solutions that are not currently installed. Import the following solutions before Importing this one. {1}
		/// </summary>
		ImportDependencySolutionError = -2147188684,

		/// <summary>
		/// This import has failed because a different entity with the identical name, {0}, already exists in the target organization.
		/// </summary>
		ImportDuplicateEntity = -2147188468,

		/// <summary>
		/// There was an error in parsing the email templates in Import Xml
		/// </summary>
		ImportEmailTemplateError = -2147188724,

		/// <summary>
		/// E-mail Template '{0}' import: The attachment '{1}' was not found in the import zip file.
		/// </summary>
		ImportEmailTemplateErrorMissingFile = -2147188693,

		/// <summary>
		/// E-mail Template was not imported. The Template is a personal template on the target system; import cannot overwrite personal templates.
		/// </summary>
		ImportEmailTemplatePersonalError = -2147188716,

		/// <summary>
		/// Invalid Custom Resources in the Import File
		/// </summary>
		ImportEntityCustomResourcesError = -2147188734,

		/// <summary>
		/// Invalid Entity new string in the Custom Resources
		/// </summary>
		ImportEntityCustomResourcesNewStringError = -2147188733,

		/// <summary>
		/// Invalid Icon in the Import File
		/// </summary>
		ImportEntityIconError = -2147188735,

		/// <summary>
		/// The number of format parameters passed into the input string is incorrect
		/// </summary>
		ImportEntityNameMismatchError = -2147188728,

		/// <summary>
		/// The systemuser entity was imported but customized forms for the entity were not imported. Systemuser entity forms from on-premises or hosted versions of Microsoft Dynamics 365 cannot be imported into Microsoft Dynamics 365 Online.
		/// </summary>
		ImportEntitySystemUserLiveMismatchError = -2147188699,

		/// <summary>
		/// The systemuser entity was imported, but customized forms for the entity were not imported. Systemuser entity forms from Microsoft Dynamics 365 Online cannot be imported into on-premises or hosted versions of Microsoft Dynamics 365.
		/// </summary>
		ImportEntitySystemUserOnPremiseMismatchError = -2147188700,

		/// <summary>
		/// This message is no longer available. Please consult the SDK for alternative messages.
		/// </summary>
		ImportExportDeprecatedError = -2147188667,

		/// <summary>
		/// Some field security permissions could not be imported because the following fields are not in the system: {0}.
		/// </summary>
		ImportFieldSecurityProfileAttributesMissingError = -2147188636,

		/// <summary>
		/// An error occurred while importing Field Security Profile.
		/// </summary>
		ImportFieldSecurityProfileError = -2147188622,

		/// <summary>
		/// Some field security permissions could not be imported because the following fields are not securable: {0}.
		/// </summary>
		ImportFieldSecurityProfileIsSecuredMissingError = -2147188637,

		/// <summary>
		/// The number of format parameters passed into the input string is incorrect
		/// </summary>
		ImportFieldXmlError = -2147188730,

		/// <summary>
		/// Import and extraction of the file failed.
		/// </summary>
		ImportFileFailed = -2147155675,

		/// <summary>
		/// The import file has an invalid digital signature.
		/// </summary>
		ImportFileSignatureInvalid = -2147188635,

		/// <summary>
		/// The import file is too large to upload.
		/// </summary>
		ImportFileTooLargeToUpload = -2147220619,

		/// <summary>
		/// Unprocessed files found: {0}
		/// </summary>
		ImportFileUnprocessed = -2147016651,

		/// <summary>
		/// The number of format parameters passed into the input string is incorrect
		/// </summary>
		ImportFormXmlError = -2147188729,

		/// <summary>
		/// An error occurred while importing generic entities.
		/// </summary>
		ImportGenericEntitiesError = -2147188704,

		/// <summary>
		/// The import failed. For more information, see the related error messages.
		/// </summary>
		ImportGenericError = -2147188706,

		/// <summary>
		/// A hierarchy rule with the same id is marked as deleted in the system,So first publish the customized entity and import again.
		/// </summary>
		ImportHierarchyRuleDeletedError = -2147157599,

		/// <summary>
		/// Cannot reuse existing hierarchy rule.
		/// </summary>
		ImportHierarchyRuleExistingError = -2147157598,

		/// <summary>
		/// There was an error processing hierarchy rules of the same object type code.(unresolvable system collision)
		/// </summary>
		ImportHierarchyRuleOtcMismatchError = -2147157597,

		/// <summary>
		/// Invalid Import File
		/// </summary>
		ImportInvalidFileError = -2147188736,

		/// <summary>
		/// The privilege to be imported is invalid
		/// </summary>
		ImportInvalidPrivilegeError = -2147188648,

		/// <summary>
		/// This solution package cannot be imported because it contains invalid XML. You can attempt to repair the file by manually editing the XML contents using the information found in the schema validation errors, or you can contact your solution provider.
		/// </summary>
		ImportInvalidXmlError = -2147188692,

		/// <summary>
		/// There was an error parsing the IsvConfig during Import
		/// </summary>
		ImportIsvConfigError = -2147188722,

		/// <summary>
		/// Translated labels for the following languages could not be imported because they have not been enabled for this organization: {0}
		/// </summary>
		ImportLanguagesIgnoredError = -2147188698,

		/// <summary>
		/// The {0} mail merge template was not imported because the {1} entity associated with this template is not in the target system.
		/// </summary>
		ImportMailMergeTemplateEntityMissingError = -2147187584,

		/// <summary>
		/// There was an error in parsing the mail merge templates in Import Xml
		/// </summary>
		ImportMailMergeTemplateError = -2147187626,

		/// <summary>
		/// One or more of the selected data maps cannot be deleted because it is currently used in a data import.
		/// </summary>
		ImportMapInUse = -2147187611,

		/// <summary>
		/// The XML file has one or more invalid IDs. The specified ID cannot be used as a unique identifier.
		/// </summary>
		ImportMappingsInvalidIdSpecified = -2147187673,

		/// <summary>
		/// This customization file contains a reference to an entity map that does not exist on the target system.
		/// </summary>
		ImportMappingsMissingEntityMapError = -2147188720,

		/// <summary>
		/// Import cannot create system attribute mappings
		/// </summary>
		ImportMappingsSystemMapError = -2147188721,

		/// <summary>
		/// Cannot add a Root Component {0} of type {1} because it is not in the target system.
		/// </summary>
		ImportMissingComponent = -2147188705,

		/// <summary>
		/// The following solution cannot be imported: {0}. Some dependencies are missing.
		/// </summary>
		ImportMissingDependenciesError = -2147188707,

		/// <summary>
		/// The import has failed because component {0} of type {1} is not declared in the solution file as a root component. To fix this, import again using the XML file that was generated when you exported the solution.
		/// </summary>
		ImportMissingRootComponentEntry = -2147188678,

		/// <summary>
		/// An error occurred while importing Mobile Offline Profiles.
		/// </summary>
		ImportMobileOfflineProfileError = -2147087969,

		/// <summary>
		/// Existing plug-in types have been removed. Please update major or minor verion of plug-in assembly.
		/// </summary>
		ImportNewPluginTypesError = -2147188623,

		/// <summary>
		/// Invalid customization file. This file is not well formed.
		/// </summary>
		ImportNonWellFormedFileError = -2147188717,

		/// <summary>
		/// One or more imports are not in completed state. Imported records can only be deleted from completed jobs. Wait until job completes, and then try again.
		/// </summary>
		ImportNotComplete = -2147187598,

		/// <summary>
		/// One or more of the Import Child Jobs Failed
		/// </summary>
		ImportOperationChildFailure = -2147204300,

		/// <summary>
		/// Attribute '{0}' was not imported as it references a non-existing global Option Set ('{1}').
		/// </summary>
		ImportOptionSetAttributeError = -2147188679,

		/// <summary>
		/// An error occurred while importing OptionSets.
		/// </summary>
		ImportOptionSetsError = -2147188688,

		/// <summary>
		/// There was an error parsing the Organization Settings during Import.
		/// </summary>
		ImportOrgSettingsError = -2147188711,

		/// <summary>
		/// An error occurred while importing plug-in types.
		/// </summary>
		ImportPluginTypesError = -2147188718,

		/// <summary>
		/// The number of format parameters passed into the input string is incorrect
		/// </summary>
		ImportRelationshipRoleMapsError = -2147188726,

		/// <summary>
		/// The number of format parameters passed into the input string is incorrect
		/// </summary>
		ImportRelationshipRolesError = -2147188727,

		/// <summary>
		/// {0} cannot be imported. The {1} privilege is required to import this component.
		/// </summary>
		ImportRelationshipRolesPrivilegeError = -2147188689,

		/// <summary>
		/// An error occurred while importing Reports.
		/// </summary>
		ImportReportsError = -2147188686,

		/// <summary>
		/// Solution ID provided is restricted and cannot be imported.
		/// </summary>
		ImportRestrictedSolutionError = -2147160057,

		/// <summary>
		/// An error occurred while importing Ribbons.
		/// </summary>
		ImportRibbonsError = -2147188687,

		/// <summary>
		/// Cannot import security role. The role with specified role id is not updatable or role name is not unique.
		/// </summary>
		ImportRoleError = -2147188713,

		/// <summary>
		/// You do not have the necessary privileges to import security roles.
		/// </summary>
		ImportRolePermissionError = -2147188712,

		/// <summary>
		/// An error occurred while importing Routing Rule Sets.
		/// </summary>
		ImportRoutingRuleError = -2147157913,

		/// <summary>
		/// A saved query with the same id is marked as deleted in the system. Please first publish the customized entity and import again.
		/// </summary>
		ImportSavedQueryDeletedError = -2147188709,

		/// <summary>
		/// The number of format parameters passed into the input string is incorrect
		/// </summary>
		ImportSavedQueryExistingError = -2147188731,

		/// <summary>
		/// There was an error processing saved queries of the same object type code (unresolvable system collision)
		/// </summary>
		ImportSavedQueryOtcMismatchError = -2147188732,

		/// <summary>
		/// An error occurred while importing Sdk Messages.
		/// </summary>
		ImportSdkMessagesError = -2147188714,

		/// <summary>
		/// An error occurred while importing Service Endpoints.
		/// </summary>
		ImportServiceEndpointError = -2147188621,

		/// <summary>
		/// An error occurred while importing the Site Map.
		/// </summary>
		ImportSiteMapError = -2147188719,

		/// <summary>
		/// An error occurred while importing SLAs.
		/// </summary>
		ImportSlaError = -2147157912,

		/// <summary>
		/// An error occurred while importing a Solution.
		/// </summary>
		ImportSolutionError = -2147188685,

		/// <summary>
		/// ISV Config was overwritten.
		/// </summary>
		ImportSolutionIsvConfigWarning = -2147188670,

		/// <summary>
		/// Solution '{0}' already exists in this system as managed and cannot be upgraded.
		/// </summary>
		ImportSolutionManagedError = -2147188680,

		/// <summary>
		/// The solution is already installed on this system as an unmanaged solution and the package supplied is attempting to install it in managed mode. Import can only update solutions when the modes match. Uninstall the current solution and try again.
		/// </summary>
		ImportSolutionManagedToUnmanagedMismatch = -2147188672,

		/// <summary>
		/// Organization settings were overwritten.
		/// </summary>
		ImportSolutionOrganizationSettingsWarning = -2147188668,

		/// <summary>
		/// The solution package you are importing was generated on Microsoft Dynamics 365 Online, it cannot be imported into on-premises or hosted versions of Microsoft Dynamics 365.
		/// </summary>
		ImportSolutionPackageInvalidSku = -2147188629,

		/// <summary>
		/// You can only import solutions with a package version of {0} or earlier into this organization. Also, you can't import any solutions into this organization that were exported from Microsoft Dynamics 365 2011 or earlier.
		/// </summary>
		ImportSolutionPackageInvalidSolutionPackageVersion = -2147188632,

		/// <summary>
		/// Deprecated, not removing now as it might cause issues during integrations.
		/// </summary>
		ImportSolutionPackageMinimumVersionNeeded = 1,

		/// <summary>
		/// The solution package you are importing was generated on a different version of Microsoft Dynamics 365. The system will attempt to transform the package prior to import. Package Version: {0} {1}, System Version: {2} {3}.
		/// </summary>
		ImportSolutionPackageNeedsUpgrade = -2147188633,

		/// <summary>
		/// The solution package you are importing was generated on a version of Microsoft Dynamics 365 that cannot be imported into this system. Package Version: {0} {1}, System Version: {2} {3}.
		/// </summary>
		ImportSolutionPackageNotValid = -2147188634,

		/// <summary>
		/// Some components in the solution package you are importing require opt in. Opt in is available, please consult your administrator.
		/// </summary>
		ImportSolutionPackageRequiresOptInAvailable = -2147188631,

		/// <summary>
		/// The solution package you are importing was generated on a SKU of Microsoft Dynamics 365 that supports opt in. It cannot be imported in your system.
		/// </summary>
		ImportSolutionPackageRequiresOptInNotAvailable = -2147188630,

		/// <summary>
		/// An error occurred while importing Solution Package Upgrade.
		/// </summary>
		ImportSolutionPackageUpgradeError = -2147188620,

		/// <summary>
		/// SiteMap was overwritten.
		/// </summary>
		ImportSolutionSiteMapWarning = -2147188669,

		/// <summary>
		/// The solution is already installed on this system as a managed solution and the package supplied is attempting to install it in unmanaged mode. Import can only update solutions when the modes match. Uninstall the current solution and try again.
		/// </summary>
		ImportSolutionUnmanagedToManagedMismatch = -2147188671,

		/// <summary>
		/// System solution cannot be imported.
		/// </summary>
		ImportSystemSolutionError = -2147188666,

		/// <summary>
		/// You cannot import this template because its language is not enabled in your Microsoft Dynamics 365 organization.
		/// </summary>
		ImportTemplateLanguageIgnored = -2147187590,

		/// <summary>
		/// You cannot import this template because it is set as "personal" in your Microsoft Dynamics 365 organization.
		/// </summary>
		ImportTemplatePersonalIgnored = -2147187589,

		/// <summary>
		/// An error occurred while importing the translations. The solution associated with the translations does not exist in this system.
		/// </summary>
		ImportTranslationMissingSolutionError = -2147188665,

		/// <summary>
		/// The translation file is invalid. The compressed file must contain the following files at its root: {0}, [Content_Types].xml.
		/// </summary>
		ImportTranslationsBadZipFileError = -2147188639,

		/// <summary>
		/// A saved query visualization with id {0} is marked for deletion in the system. Please publish the customized entity first and then import again.
		/// </summary>
		ImportVisualizationDeletedError = -2147164141,

		/// <summary>
		/// A saved query visualization with id {0} already exists in the system, and cannot be resused by a new custom entity.
		/// </summary>
		ImportVisualizationExistingError = -2147164140,

		/// <summary>
		/// This import process is trying to import {0} new custom entities. This would exceed the custom entity limits for this organization.
		/// </summary>
		ImportWillExceedCustomEntityQuota = -2147176381,

		/// <summary>
		/// Cannot import workflow definition. Required attribute dependency is missing.
		/// </summary>
		ImportWorkflowAttributeDependencyError = -2147188702,

		/// <summary>
		/// Cannot import workflow definition. Required entity dependency is missing.
		/// </summary>
		ImportWorkflowEntityDependencyError = -2147188701,

		/// <summary>
		/// Cannot import workflow definition. The workflow with specified workflow id is not updatable or workflow name is not unique.
		/// </summary>
		ImportWorkflowError = -2147188703,

		/// <summary>
		/// Workflow {0} cannot be imported because a workflow with same name and different unique identifier exists in the target system. Change the name of this workflow, and then try again.
		/// </summary>
		ImportWorkflowNameConflictError = -2147188697,

		/// <summary>
		/// Workflow {0}({1}) cannot be imported because a workflow with same unique identifier is published on the target system. Unpublish the workflow on the target system before attempting to import this workflow again.
		/// </summary>
		ImportWorkflowPublishedError = -2147188696,

		/// <summary>
		/// The following managed solution cannot be imported: {0}. The publisher name cannot be changed from {1} to {2}.
		/// </summary>
		ImportWrongPublisherError = -2147188708,

		/// <summary>
		/// The import file is invalid. XSD validation failed with the following error: '{0}'. The validation failed at: '...{1} <<<<
		/// </summary>
		ImportXsdValidationError = -2147188710,
	}

}
