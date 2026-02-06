# Changelog

All notable changes to TS4 SimRipper will be documented in this file.

## [Unreleased]

### Added
- Application icon (`ts4.ico`) displayed in window title bar and taskbar for all forms
- Progress feedback during Sim loading ("Loading rig...", "Loading outfit X/Y...", "Building mesh...")
- Package caching system to avoid reopening same game files multiple times
- Tooltips on all main action buttons (OBJ, MS3D, DAE, textures, etc.)

### Changed
- Improved UI responsiveness during loading operations with `Application.DoEvents()`
- Updated About dialog with original author credits and fork contributor info

### Fixed
- Removed unused variables causing compiler warnings (`modHash`, `tmp`, `dummy`, `morphPreview3`)

---

## [3.14.2.11] - 2026-02-06

### Added
- Support for CASP version 52 (February 2026 game update)
  - Added `reserved3` field for CASP v52 compatibility

### Fixed
- Fixed Sims appearing invisible after February 2026 game update (v1.121.342.1030)
- Fixed head/face not rendering for Sims
- Fixed NPCs not loading correctly

### Technical Changes
- Added bounds checking for array access in `CASP.MeshParts()`, `CASP.getLOD()`, `CASP.getLODandPart()`
- Added null checks for `frameModifier`, `LinkList`, and `TGIList` accesses
- Added public `Version`, `LodCount`, `TGICount`, and `LodInfo` properties to CASP class for debugging

## [3.14.2.10] - Previous Release

### Notes
- Last version before February 2026 game compatibility update
- Works with game versions up to 1.120.x
