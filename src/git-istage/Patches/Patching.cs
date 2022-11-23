﻿using System.Text;
        var entryLines = lineIndexes.Select(i => (LineIndex: i, Entry: document.FindEntry(i)!))
                                    .GroupBy(t => t.Entry, t => t.LineIndex);
            var hunkLines = entryLine.Select(i => (LineIndex: i, Hunk: entry.FindHunk(i)!))
                                     .GroupBy(t => t.Hunk, t => t.LineIndex);
                                   .Select(l => l.Kind)
                                   .Where(k => k.IsAdditionOrRemoval())
                                   .Select(k => k == PatchLineKind.Addition ? 1 : -1)
                                   .Sum();
                    newPatch.Append($"--- {oldPath}\n");
                    newPatch.Append($"new file mode {changes.Mode}\n");

                newPatch.Append($"+++ b/{path}\n");
                        newPatch.Append(line.LineBreak);
                        newPatch.Append(line.LineBreak);