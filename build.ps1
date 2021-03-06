Framework 4.7

Properties {
    $Configuration = "Release"
    $RootFolder = $psake.build_script_dir
    $SolutionFolder = Join-Path -Path $RootFolder -ChildPath CBreeze
}

function Invoke-MSBuild
{
    param
    (
        [ValidateNotNullOrEmpty()][string]$Target = 'Rebuild',
        [Parameter(Mandatory, Position = 1)][ValidateSet('NAV2017', 'NAV2016', 'NAV2015', 'NAV2013R2', 'NAV2013')][string]$NAVVersion,
        [ValidateSet('quiet', 'minimal', 'normal', 'detailed', 'diagnostic')]$Verbosity = 'quiet'
    )

    $SolutionFileName = Join-Path -Path $SolutionFolder -ChildPath 'UncommonSense.CBreeze.sln'

    <#
    $OutputFolderPath = Join-Path -Path $SolutionFolder -ChildPath "Output/$NAVVersion/$Configuration"

    if (Test-Path -Path $OutputFolderPath)
    {
        Write-Information "Removing output folder $OutputFolderPath"
        Remove-Item -Path $OutputFolderPath -Force -Recurse
    }

    Write-Information "Creating output folder $OutputFolderPath"
    New-Item -Path $OutputFolderPath -ItemType Directory | Out-Null
    #>

    $DefineConstants = switch ($NAVVersion)
    {
        'NAV2017'
        {
            'NAV2017 NAV2016 NAV2015 NAV2013R2 NAV2013'
        }
        'NAV2016'
        {
            'NAV2016 NAV2015 NAV2013R2 NAV2013'
        }
        'NAV2015'
        {
            'NAV2015 NAV2013R2 NAV2013'
        }
        'NAV2013R2'
        {
            'NAV2013R2 NAV2013'
        }
        'NAV2013'
        {
            'NAV2013'
        }
    }

    Exec { msbuild /target:$Target /property:Configuration=$Configuration /property:DefineConstants="$DefineConstants" /p:NoWarn=1591 /verbosity:$Verbosity $SolutionFileName }
    #Move-Item -Path (Join-Path -Path $SolutionFolder -ChildPath "UncommonSense.CBreeze.Automation/bin/$Configuration/UncommonSense.CBreeze.Automation/*") -Destination $OutputFolderPath
}

Task -Name Default -Depends Build2017 #, Build2016, Build2015, Build2013R2, Build2013

Task -Name Build2017 {
    Invoke-MSBuild NAV2017
}

Task -Name Build2016 {
    Invoke-MSBuild NAV2016
}

Task -Name Build2015 {
    Invoke-MSBuild NAV2015
}

Task -Name Build2013R2 {
    Invoke-MSBuild NAV2013R2
}

Task -Name Build2013 {
    Invoke-MSBuild NAV2013
}