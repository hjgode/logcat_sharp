﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogcatSharp
{
    #region newPackageCmd
    /*
    1|CT60-L0-C:/ $ cmd package
    Package manager(package) commands:
      help
        Print this help text.

      compile[-m MODE | -r REASON][-f][-c]
              [--reset][--check - prof(true | false)] (-a | TARGET-PACKAGE)
        Trigger compilation of TARGET-PACKAGE or all packages if "-a".
        Options:
          -a: compile all packages
          -c: clear profile data before compiling
          -f: force compilation even if not needed
          -m: select compilation mode
              MODE is one of the dex2oat compiler filters:
                verify-none
                verify-at-runtime
                verify-profile
                interpret-only
                space-profile
                space
                speed-profile
                speed
                everything
          -r: select compilation reason
              REASON is one of:
                first-boot
                boot
                install
                bg-dexopt
                ab-ota
                nsys-library
                shared-apk
                forced-dexopt
                core-app
          --reset: restore package to its post-install state
          --check-prof (true | false): look at profiles when doing dexopt?
      list features
        Prints all features of the system.
      list instrumentation[-f]
        [TARGET-PACKAGE]
        Prints all test packages; optionally only those targeting TARGET-PACKAGE
        Options:
          -f: dump the name of the .apk file containing the test package
      list libraries
        Prints all system libraries.
      list packages[-f]
        [-d]
        [-e]
        [-s]
        [-3]
        [-i]
        [-u]
        [--user USER_ID]
        [FILTER]
        Prints all packages; optionally only those whose name contains
        the text in FILTER.
        Options:
          -f: see their associated file
          -d: filter to only show disabled packages
          -e: filter to only show enabled packages
          -s: filter to only show system packages
          -3: filter to only show third party packages
          -i: see the installer for the packages
          -u: also include uninstalled packages
      list permission-groups
        Prints all known permission groups.
      list permissions[-g]
        [-f]
        [-d]
        [-u]
        [GROUP]
        Prints all known permissions; optionally only those in GROUP.
        Options:
          -g: organize by group
          -f: print all information
          -s: short summary
          -d: only list dangerous permissions
          -u: list only the permissions users will see
      dump-profiles TARGET-PACKAGE
        Dumps method/class profile files to
        /data/misc/profman/TARGET-PACKAGE.txt
      resolve-activity[--brief][--components][--user USER_ID] INTENT
        Prints the activity that resolves to the given Intent.
      query-activities[--brief][--components][--user USER_ID] INTENT
        Prints all activities that can handle the given Intent.
      query-services[--brief][--components][--user USER_ID] INTENT
        Prints all services that can handle the given Intent.
      query-receivers[--brief][--components][--user USER_ID] INTENT
        Prints all broadcast receivers that can handle the given Intent.
      suspend [--user USER_ID] TARGET-PACKAGE
        Suspends the specified package (as user).
      unsuspend[--user USER_ID] TARGET-PACKAGE
       Unsuspends the specified package(as user).
      set-home-activity[--user USER_ID] TARGET-COMPONENT
       set the default home activity(aka launcher).

    <INTENT> specifications include these flags and arguments:
        [-a<ACTION>]
        [-d<DATA_URI>]
        [-t<MIME_TYPE>]
        [-c<CATEGORY> [-c<CATEGORY>] ...]
        [-e|--es<EXTRA_KEY> <EXTRA_STRING_VALUE> ...]
        [--esn<EXTRA_KEY>...]
        [--ez<EXTRA_KEY> <EXTRA_BOOLEAN_VALUE> ...]
        [--ei<EXTRA_KEY> <EXTRA_INT_VALUE> ...]
        [--el<EXTRA_KEY> <EXTRA_LONG_VALUE> ...]
        [--ef<EXTRA_KEY> <EXTRA_FLOAT_VALUE> ...]
        [--eu<EXTRA_KEY> <EXTRA_URI_VALUE> ...]
        [--ecn<EXTRA_KEY> <EXTRA_COMPONENT_NAME_VALUE>]
        [--eia<EXTRA_KEY> <EXTRA_INT_VALUE>[,<EXTRA_INT_VALUE...]]
            (mutiple extras passed as Integer[])
        [--eial<EXTRA_KEY> <EXTRA_INT_VALUE>[,<EXTRA_INT_VALUE...]]
            (mutiple extras passed as List<Integer>)
        [--ela<EXTRA_KEY> <EXTRA_LONG_VALUE>[,<EXTRA_LONG_VALUE...]]
            (mutiple extras passed as Long[])
        [--elal<EXTRA_KEY> <EXTRA_LONG_VALUE>[,<EXTRA_LONG_VALUE...]]
            (mutiple extras passed as List<Long>)
        [--efa<EXTRA_KEY> <EXTRA_FLOAT_VALUE>[,<EXTRA_FLOAT_VALUE...]]
            (mutiple extras passed as Float[])
        [--efal<EXTRA_KEY> <EXTRA_FLOAT_VALUE>[,<EXTRA_FLOAT_VALUE...]]
            (mutiple extras passed as List<Float>)
        [--esa<EXTRA_KEY> <EXTRA_STRING_VALUE>[,<EXTRA_STRING_VALUE...]]
            (mutiple extras passed as String[]; to embed a comma into a string,
             escape it using "\,")
        [--esal<EXTRA_KEY> <EXTRA_STRING_VALUE>[,<EXTRA_STRING_VALUE...]]
            (mutiple extras passed as List<String>; to embed a comma into a string,
             escape it using "\,")
        [--f<FLAG>]
        [--grant-read-uri-permission]
        [--grant-write-uri-permission]
        [--grant-persistable-uri-permission]
        [--grant-prefix-uri-permission]
        [--debug-log-resolution]
        [--exclude-stopped-packages]
        [--include-stopped-packages]
        [--activity-brought-to-front]
        [--activity-clear-top]
        [--activity-clear-when-task-reset]
        [--activity-exclude-from-recents]
        [--activity-launched-from-history]
        [--activity-multiple-task]
        [--activity-no-animation]
        [--activity-no-history]
        [--activity-no-user-action]
        [--activity-previous-is-top]
        [--activity-reorder-to-front]
        [--activity-reset-task-if-needed]
        [--activity-single-top]
        [--activity-clear-task]
        [--activity-task-on-home]
        [--receiver-registered-only]
        [--receiver-replace-pending]
        [--receiver-foreground]
        [--selector]
        [<URI> | <PACKAGE> | <COMPONENT>]
        CT60-L0-C:/ $

        EXAMPLE:
        cmd package list packages -e
        cmd package list packages -d
        cmd package list packages -3
        */
    #endregion
    class package
    {
        public string name { get; set; }
        public package(String sPackageLine)
        {
            if (sPackageLine == null)
                return;
            if (sPackageLine.StartsWith("package:"))
            {
                name = sPackageLine.Substring(("package:").Length);
            }
            else
                name = sPackageLine;
            
        }
        
        public override String ToString()
        {
            return this.name;
        }
    }
}
