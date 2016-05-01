﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlueprintList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlueprintList))
        Me.treBlueprintTreeView = New System.Windows.Forms.TreeView()
        Me.lblIntro = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpBPType = New System.Windows.Forms.GroupBox()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.rbtnBPShipBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnAmmoChargeBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPDroneBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPStructureBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPRigBlueprints = New System.Windows.Forms.RadioButton()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.rbtnBPModuleBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPBoosterBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPSubsystemBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPOwnedBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPCelestialsBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPDeployableBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPComponentBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPMiscBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPStationPartsBlueprints = New System.Windows.Forms.RadioButton()
        Me.rbtnBPFavoriteBlueprints = New System.Windows.Forms.RadioButton()
        Me.grpBPSize = New System.Windows.Forms.GroupBox()
        Me.chkBPSmall = New System.Windows.Forms.CheckBox()
        Me.chkBPMedium = New System.Windows.Forms.CheckBox()
        Me.chkBPLarge = New System.Windows.Forms.CheckBox()
        Me.chkBPXLarge = New System.Windows.Forms.CheckBox()
        Me.grpBPTechLevel = New System.Windows.Forms.GroupBox()
        Me.chkBPTech1 = New System.Windows.Forms.CheckBox()
        Me.chkBPTech2 = New System.Windows.Forms.CheckBox()
        Me.chkBPTech3 = New System.Windows.Forms.CheckBox()
        Me.chkBPStory = New System.Windows.Forms.CheckBox()
        Me.chkBPNavy = New System.Windows.Forms.CheckBox()
        Me.chkBPPirate = New System.Windows.Forms.CheckBox()
        Me.grpBPType.SuspendLayout
        Me.grpBPSize.SuspendLayout
        Me.grpBPTechLevel.SuspendLayout
        Me.SuspendLayout
        '
        'treBlueprintTreeView
        '
        Me.treBlueprintTreeView.Location = New System.Drawing.Point(12, 56)
        Me.treBlueprintTreeView.Name = "treBlueprintTreeView"
        Me.treBlueprintTreeView.Size = New System.Drawing.Size(368, 298)
        Me.treBlueprintTreeView.TabIndex = 0
        '
        'lblIntro
        '
        Me.lblIntro.AutoSize = true
        Me.lblIntro.Location = New System.Drawing.Point(12, 9)
        Me.lblIntro.Name = "lblIntro"
        Me.lblIntro.Size = New System.Drawing.Size(0, 13)
        Me.lblIntro.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(310, 637)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = true
        '
        'grpBPType
        '
        Me.grpBPType.Controls.Add(Me.rbtnBPFavoriteBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPStationPartsBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPMiscBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPComponentBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPDeployableBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPCelestialsBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPOwnedBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPSubsystemBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPBoosterBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPModuleBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPRigBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPStructureBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPDroneBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnAmmoChargeBlueprints)
        Me.grpBPType.Controls.Add(Me.rbtnBPShipBlueprints)
        Me.grpBPType.Controls.Add(Me.rdoAll)
        Me.grpBPType.Location = New System.Drawing.Point(12, 360)
        Me.grpBPType.Name = "grpBPType"
        Me.grpBPType.Size = New System.Drawing.Size(236, 237)
        Me.grpBPType.TabIndex = 3
        Me.grpBPType.TabStop = false
        Me.grpBPType.Text = "Blueprint Type"
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = true
        Me.rdoAll.Checked = true
        Me.rdoAll.Location = New System.Drawing.Point(7, 20)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(36, 17)
        Me.rdoAll.TabIndex = 0
        Me.rdoAll.TabStop = true
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = true
        '
        'rbtnBPShipBlueprints
        '
        Me.rbtnBPShipBlueprints.AutoSize = true
        Me.rbtnBPShipBlueprints.Location = New System.Drawing.Point(6, 43)
        Me.rbtnBPShipBlueprints.Name = "rbtnBPShipBlueprints"
        Me.rbtnBPShipBlueprints.Size = New System.Drawing.Size(51, 17)
        Me.rbtnBPShipBlueprints.TabIndex = 1
        Me.rbtnBPShipBlueprints.Text = "Ships"
        Me.rbtnBPShipBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnAmmoChargeBlueprints
        '
        Me.rbtnAmmoChargeBlueprints.AutoSize = true
        Me.rbtnAmmoChargeBlueprints.Location = New System.Drawing.Point(7, 68)
        Me.rbtnAmmoChargeBlueprints.Name = "rbtnAmmoChargeBlueprints"
        Me.rbtnAmmoChargeBlueprints.Size = New System.Drawing.Size(123, 17)
        Me.rbtnAmmoChargeBlueprints.TabIndex = 2
        Me.rbtnAmmoChargeBlueprints.Text = "Ammunition/Charges"
        Me.rbtnAmmoChargeBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPDroneBlueprints
        '
        Me.rbtnBPDroneBlueprints.AutoSize = true
        Me.rbtnBPDroneBlueprints.Location = New System.Drawing.Point(137, 91)
        Me.rbtnBPDroneBlueprints.Name = "rbtnBPDroneBlueprints"
        Me.rbtnBPDroneBlueprints.Size = New System.Drawing.Size(59, 17)
        Me.rbtnBPDroneBlueprints.TabIndex = 3
        Me.rbtnBPDroneBlueprints.Text = "Drones"
        Me.rbtnBPDroneBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPStructureBlueprints
        '
        Me.rbtnBPStructureBlueprints.AutoSize = true
        Me.rbtnBPStructureBlueprints.Location = New System.Drawing.Point(6, 114)
        Me.rbtnBPStructureBlueprints.Name = "rbtnBPStructureBlueprints"
        Me.rbtnBPStructureBlueprints.Size = New System.Drawing.Size(73, 17)
        Me.rbtnBPStructureBlueprints.TabIndex = 4
        Me.rbtnBPStructureBlueprints.Text = "Structures"
        Me.rbtnBPStructureBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPRigBlueprints
        '
        Me.rbtnBPRigBlueprints.AutoSize = true
        Me.rbtnBPRigBlueprints.Location = New System.Drawing.Point(136, 68)
        Me.rbtnBPRigBlueprints.Name = "rbtnBPRigBlueprints"
        Me.rbtnBPRigBlueprints.Size = New System.Drawing.Size(46, 17)
        Me.rbtnBPRigBlueprints.TabIndex = 5
        Me.rbtnBPRigBlueprints.Text = "Rigs"
        Me.rbtnBPRigBlueprints.UseVisualStyleBackColor = true
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(229, 637)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = true
        '
        'rbtnBPModuleBlueprints
        '
        Me.rbtnBPModuleBlueprints.AutoSize = true
        Me.rbtnBPModuleBlueprints.Location = New System.Drawing.Point(137, 43)
        Me.rbtnBPModuleBlueprints.Name = "rbtnBPModuleBlueprints"
        Me.rbtnBPModuleBlueprints.Size = New System.Drawing.Size(65, 17)
        Me.rbtnBPModuleBlueprints.TabIndex = 6
        Me.rbtnBPModuleBlueprints.Text = "Modules"
        Me.rbtnBPModuleBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPBoosterBlueprints
        '
        Me.rbtnBPBoosterBlueprints.AutoSize = true
        Me.rbtnBPBoosterBlueprints.Location = New System.Drawing.Point(6, 91)
        Me.rbtnBPBoosterBlueprints.Name = "rbtnBPBoosterBlueprints"
        Me.rbtnBPBoosterBlueprints.Size = New System.Drawing.Size(66, 17)
        Me.rbtnBPBoosterBlueprints.TabIndex = 7
        Me.rbtnBPBoosterBlueprints.Text = "Boosters"
        Me.rbtnBPBoosterBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPSubsystemBlueprints
        '
        Me.rbtnBPSubsystemBlueprints.AutoSize = true
        Me.rbtnBPSubsystemBlueprints.Location = New System.Drawing.Point(137, 114)
        Me.rbtnBPSubsystemBlueprints.Name = "rbtnBPSubsystemBlueprints"
        Me.rbtnBPSubsystemBlueprints.Size = New System.Drawing.Size(81, 17)
        Me.rbtnBPSubsystemBlueprints.TabIndex = 8
        Me.rbtnBPSubsystemBlueprints.Text = "Subsystems"
        Me.rbtnBPSubsystemBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPOwnedBlueprints
        '
        Me.rbtnBPOwnedBlueprints.AutoSize = true
        Me.rbtnBPOwnedBlueprints.Location = New System.Drawing.Point(137, 20)
        Me.rbtnBPOwnedBlueprints.Name = "rbtnBPOwnedBlueprints"
        Me.rbtnBPOwnedBlueprints.Size = New System.Drawing.Size(59, 17)
        Me.rbtnBPOwnedBlueprints.TabIndex = 9
        Me.rbtnBPOwnedBlueprints.Text = "Owned"
        Me.rbtnBPOwnedBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPCelestialsBlueprints
        '
        Me.rbtnBPCelestialsBlueprints.AutoSize = true
        Me.rbtnBPCelestialsBlueprints.Location = New System.Drawing.Point(6, 137)
        Me.rbtnBPCelestialsBlueprints.Name = "rbtnBPCelestialsBlueprints"
        Me.rbtnBPCelestialsBlueprints.Size = New System.Drawing.Size(69, 17)
        Me.rbtnBPCelestialsBlueprints.TabIndex = 10
        Me.rbtnBPCelestialsBlueprints.Text = "Celestials"
        Me.rbtnBPCelestialsBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPDeployableBlueprints
        '
        Me.rbtnBPDeployableBlueprints.AutoSize = true
        Me.rbtnBPDeployableBlueprints.Location = New System.Drawing.Point(136, 137)
        Me.rbtnBPDeployableBlueprints.Name = "rbtnBPDeployableBlueprints"
        Me.rbtnBPDeployableBlueprints.Size = New System.Drawing.Size(78, 17)
        Me.rbtnBPDeployableBlueprints.TabIndex = 11
        Me.rbtnBPDeployableBlueprints.Text = "Deployable"
        Me.rbtnBPDeployableBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPComponentBlueprints
        '
        Me.rbtnBPComponentBlueprints.AutoSize = true
        Me.rbtnBPComponentBlueprints.Location = New System.Drawing.Point(7, 161)
        Me.rbtnBPComponentBlueprints.Name = "rbtnBPComponentBlueprints"
        Me.rbtnBPComponentBlueprints.Size = New System.Drawing.Size(84, 17)
        Me.rbtnBPComponentBlueprints.TabIndex = 12
        Me.rbtnBPComponentBlueprints.Text = "Components"
        Me.rbtnBPComponentBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPMiscBlueprints
        '
        Me.rbtnBPMiscBlueprints.AutoSize = true
        Me.rbtnBPMiscBlueprints.Location = New System.Drawing.Point(136, 161)
        Me.rbtnBPMiscBlueprints.Name = "rbtnBPMiscBlueprints"
        Me.rbtnBPMiscBlueprints.Size = New System.Drawing.Size(92, 17)
        Me.rbtnBPMiscBlueprints.TabIndex = 13
        Me.rbtnBPMiscBlueprints.Text = "Miscellaneous"
        Me.rbtnBPMiscBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPStationPartsBlueprints
        '
        Me.rbtnBPStationPartsBlueprints.AutoSize = true
        Me.rbtnBPStationPartsBlueprints.Location = New System.Drawing.Point(6, 185)
        Me.rbtnBPStationPartsBlueprints.Name = "rbtnBPStationPartsBlueprints"
        Me.rbtnBPStationPartsBlueprints.Size = New System.Drawing.Size(85, 17)
        Me.rbtnBPStationPartsBlueprints.TabIndex = 14
        Me.rbtnBPStationPartsBlueprints.Text = "Station Parts"
        Me.rbtnBPStationPartsBlueprints.UseVisualStyleBackColor = true
        '
        'rbtnBPFavoriteBlueprints
        '
        Me.rbtnBPFavoriteBlueprints.AutoSize = true
        Me.rbtnBPFavoriteBlueprints.Location = New System.Drawing.Point(136, 185)
        Me.rbtnBPFavoriteBlueprints.Name = "rbtnBPFavoriteBlueprints"
        Me.rbtnBPFavoriteBlueprints.Size = New System.Drawing.Size(68, 17)
        Me.rbtnBPFavoriteBlueprints.TabIndex = 15
        Me.rbtnBPFavoriteBlueprints.Text = "Favorites"
        Me.rbtnBPFavoriteBlueprints.UseVisualStyleBackColor = true
        '
        'grpBPSize
        '
        Me.grpBPSize.Controls.Add(Me.chkBPXLarge)
        Me.grpBPSize.Controls.Add(Me.chkBPLarge)
        Me.grpBPSize.Controls.Add(Me.chkBPMedium)
        Me.grpBPSize.Controls.Add(Me.chkBPSmall)
        Me.grpBPSize.Location = New System.Drawing.Point(255, 360)
        Me.grpBPSize.Name = "grpBPSize"
        Me.grpBPSize.Size = New System.Drawing.Size(125, 72)
        Me.grpBPSize.TabIndex = 5
        Me.grpBPSize.TabStop = false
        Me.grpBPSize.Text = "Size Limit"
        '
        'chkBPSmall
        '
        Me.chkBPSmall.AutoSize = true
        Me.chkBPSmall.Location = New System.Drawing.Point(7, 20)
        Me.chkBPSmall.Name = "chkBPSmall"
        Me.chkBPSmall.Size = New System.Drawing.Size(33, 17)
        Me.chkBPSmall.TabIndex = 0
        Me.chkBPSmall.Text = "S"
        Me.chkBPSmall.UseVisualStyleBackColor = true
        '
        'chkBPMedium
        '
        Me.chkBPMedium.AutoSize = true
        Me.chkBPMedium.Location = New System.Drawing.Point(7, 43)
        Me.chkBPMedium.Name = "chkBPMedium"
        Me.chkBPMedium.Size = New System.Drawing.Size(35, 17)
        Me.chkBPMedium.TabIndex = 1
        Me.chkBPMedium.Text = "M"
        Me.chkBPMedium.UseVisualStyleBackColor = true
        '
        'chkBPLarge
        '
        Me.chkBPLarge.AutoSize = true
        Me.chkBPLarge.Location = New System.Drawing.Point(56, 19)
        Me.chkBPLarge.Name = "chkBPLarge"
        Me.chkBPLarge.Size = New System.Drawing.Size(32, 17)
        Me.chkBPLarge.TabIndex = 2
        Me.chkBPLarge.Text = "L"
        Me.chkBPLarge.UseVisualStyleBackColor = true
        '
        'chkBPXLarge
        '
        Me.chkBPXLarge.AutoSize = true
        Me.chkBPXLarge.Location = New System.Drawing.Point(55, 42)
        Me.chkBPXLarge.Name = "chkBPXLarge"
        Me.chkBPXLarge.Size = New System.Drawing.Size(39, 17)
        Me.chkBPXLarge.TabIndex = 3
        Me.chkBPXLarge.Text = "XL"
        Me.chkBPXLarge.UseVisualStyleBackColor = true
        '
        'grpBPTechLevel
        '
        Me.grpBPTechLevel.Controls.Add(Me.chkBPPirate)
        Me.grpBPTechLevel.Controls.Add(Me.chkBPNavy)
        Me.grpBPTechLevel.Controls.Add(Me.chkBPStory)
        Me.grpBPTechLevel.Controls.Add(Me.chkBPTech3)
        Me.grpBPTechLevel.Controls.Add(Me.chkBPTech2)
        Me.grpBPTechLevel.Controls.Add(Me.chkBPTech1)
        Me.grpBPTechLevel.Location = New System.Drawing.Point(255, 439)
        Me.grpBPTechLevel.Name = "grpBPTechLevel"
        Me.grpBPTechLevel.Size = New System.Drawing.Size(125, 158)
        Me.grpBPTechLevel.TabIndex = 6
        Me.grpBPTechLevel.TabStop = false
        Me.grpBPTechLevel.Text = "Tech Level"
        '
        'chkBPTech1
        '
        Me.chkBPTech1.Checked = true
        Me.chkBPTech1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBPTech1.Location = New System.Drawing.Point(7, 13)
        Me.chkBPTech1.Name = "chkBPTech1"
        Me.chkBPTech1.Size = New System.Drawing.Size(81, 17)
        Me.chkBPTech1.TabIndex = 0
        Me.chkBPTech1.Text = "Tech 1"
        Me.chkBPTech1.UseVisualStyleBackColor = true
        '
        'chkBPTech2
        '
        Me.chkBPTech2.AutoSize = true
        Me.chkBPTech2.Checked = true
        Me.chkBPTech2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBPTech2.Location = New System.Drawing.Point(7, 35)
        Me.chkBPTech2.Name = "chkBPTech2"
        Me.chkBPTech2.Size = New System.Drawing.Size(60, 17)
        Me.chkBPTech2.TabIndex = 1
        Me.chkBPTech2.Text = "Tech 2"
        Me.chkBPTech2.UseVisualStyleBackColor = true
        '
        'chkBPTech3
        '
        Me.chkBPTech3.AutoSize = true
        Me.chkBPTech3.Checked = true
        Me.chkBPTech3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBPTech3.Location = New System.Drawing.Point(7, 58)
        Me.chkBPTech3.Name = "chkBPTech3"
        Me.chkBPTech3.Size = New System.Drawing.Size(60, 17)
        Me.chkBPTech3.TabIndex = 2
        Me.chkBPTech3.Text = "Tech 3"
        Me.chkBPTech3.UseVisualStyleBackColor = true
        '
        'chkBPStory
        '
        Me.chkBPStory.AutoSize = true
        Me.chkBPStory.Checked = true
        Me.chkBPStory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBPStory.Location = New System.Drawing.Point(7, 82)
        Me.chkBPStory.Name = "chkBPStory"
        Me.chkBPStory.Size = New System.Drawing.Size(66, 17)
        Me.chkBPStory.TabIndex = 3
        Me.chkBPStory.Text = "Storyline"
        Me.chkBPStory.UseVisualStyleBackColor = true
        '
        'chkBPNavy
        '
        Me.chkBPNavy.AutoSize = true
        Me.chkBPNavy.Checked = true
        Me.chkBPNavy.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBPNavy.Location = New System.Drawing.Point(7, 106)
        Me.chkBPNavy.Name = "chkBPNavy"
        Me.chkBPNavy.Size = New System.Drawing.Size(51, 17)
        Me.chkBPNavy.TabIndex = 4
        Me.chkBPNavy.Text = "Navy"
        Me.chkBPNavy.UseVisualStyleBackColor = true
        '
        'chkBPPirate
        '
        Me.chkBPPirate.AutoSize = true
        Me.chkBPPirate.Checked = true
        Me.chkBPPirate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBPPirate.Location = New System.Drawing.Point(7, 130)
        Me.chkBPPirate.Name = "chkBPPirate"
        Me.chkBPPirate.Size = New System.Drawing.Size(53, 17)
        Me.chkBPPirate.TabIndex = 5
        Me.chkBPPirate.Text = "Pirate"
        Me.chkBPPirate.UseVisualStyleBackColor = true
        '
        'frmBlueprintList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 672)
        Me.Controls.Add(Me.grpBPTechLevel)
        Me.Controls.Add(Me.grpBPSize)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.grpBPType)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblIntro)
        Me.Controls.Add(Me.treBlueprintTreeView)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmBlueprintList"
        Me.Text = "Blueprint List"
        Me.grpBPType.ResumeLayout(false)
        Me.grpBPType.PerformLayout
        Me.grpBPSize.ResumeLayout(false)
        Me.grpBPSize.PerformLayout
        Me.grpBPTechLevel.ResumeLayout(false)
        Me.grpBPTechLevel.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents treBlueprintTreeView As TreeView
    Friend WithEvents lblIntro As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents grpBPType As GroupBox
    Friend WithEvents rbtnBPOwnedBlueprints As RadioButton
    Friend WithEvents rbtnBPSubsystemBlueprints As RadioButton
    Friend WithEvents rbtnBPBoosterBlueprints As RadioButton
    Friend WithEvents rbtnBPModuleBlueprints As RadioButton
    Friend WithEvents rbtnBPRigBlueprints As RadioButton
    Friend WithEvents rbtnBPStructureBlueprints As RadioButton
    Friend WithEvents rbtnBPDroneBlueprints As RadioButton
    Friend WithEvents rbtnAmmoChargeBlueprints As RadioButton
    Friend WithEvents rbtnBPShipBlueprints As RadioButton
    Friend WithEvents rdoAll As RadioButton
    Friend WithEvents btnRefresh As Button
    Friend WithEvents rbtnBPDeployableBlueprints As RadioButton
    Friend WithEvents rbtnBPCelestialsBlueprints As RadioButton
    Friend WithEvents rbtnBPMiscBlueprints As RadioButton
    Friend WithEvents rbtnBPComponentBlueprints As RadioButton
    Friend WithEvents rbtnBPStationPartsBlueprints As RadioButton
    Friend WithEvents rbtnBPFavoriteBlueprints As RadioButton
    Friend WithEvents grpBPSize As GroupBox
    Friend WithEvents chkBPXLarge As CheckBox
    Friend WithEvents chkBPLarge As CheckBox
    Friend WithEvents chkBPMedium As CheckBox
    Friend WithEvents chkBPSmall As CheckBox
    Friend WithEvents grpBPTechLevel As GroupBox
    Friend WithEvents chkBPPirate As CheckBox
    Friend WithEvents chkBPNavy As CheckBox
    Friend WithEvents chkBPStory As CheckBox
    Friend WithEvents chkBPTech3 As CheckBox
    Friend WithEvents chkBPTech2 As CheckBox
    Friend WithEvents chkBPTech1 As CheckBox
End Class