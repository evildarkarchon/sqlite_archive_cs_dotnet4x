using System.IO;
using System.Collections.Generic;
using CommandLine;

namespace sqlite_archive_cs
{
    public abstract class Options
    {
        [Value(0, Required = true, HelpText = "File name of the database to operate on.")]
        public string Db { get; set; }

        [Option('v', "verbose", HelpText = "Show additional information while performing tasks.")]
        public bool Verbose { get; set; }

        [Option('a', "autovacuum", Default = 1, HelpText = "Sets the automatic vacuum mode. (0 = disabled, 1 = full autovacuum mode, 2 = incremental autovacuum mode)")]
        public int AutoVacuum { get; set; }

    }
    [Verb("add", HelpText = "Options related to adding files to the database.")]
    public class AddFiles : Options
    {
        [Value(0, HelpText = "Name of the table to import files to.")]
        public string Table { get; set; }

        [Value(1, HelpText = "List of files to add to the database.")]
        public IEnumerable<string> Files { get; set; }

        [Option("lowercase-table-name", HelpText = "Make the case of the inferred table name lowercase (does nothing if table is specified)", Default = false)]
        public bool LowercaseTableName { get; set; }
    }
}