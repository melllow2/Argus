# Argus
USB Intrusion Detection, Response & Tracking Program


Argus is a controlled, legal research application program designed for cybersecurity education, penetration testing (with consent), and defensive strategy development. It detects USB device insertion, monitors file transfers in real-time, logs relevant metadata, and simulates advanced countermeasures in response to simulated exfiltration of sensitive data.

Key Features
1. USB Activity Detection
- Cross-platform (Windows, Linux) monitoring of USB device insertion/removal.
- Automatic session start when a new USB is detected.

2. File Transfer Metadata Logging
Records:
  - File name & extension
  - File size
  - Timestamp of copy
  - USB device serial / ID
  - Stores logs securely in encrypted local database.

3. Sensitive Data Identification
- Configurable keyword match (e.g., “classified”, “confidential”, “report”).
- Can use regular expressions or YARA rules.

4. Defensive Response Actions
- Primary: Attempt to pause or block unauthorized file transfer using OS APIs.
- Secondary (Simulated): Simulate injecting a “tracking agent” into the USB that would report:
  > System location (simulated GPS/IP lookup)
  > System identifiers (IP, MAC addresses)

5. Persistence Simulation
- Demonstrates techniques attackers might use to maintain presence:
  > Hidden files/folders
  > Multi-layered password protection for removal

6. Stealth Operations
- Runs in background without user-facing alerts during simulation.
  > All stealth actions are fully logged.

7. Access Control
- Hidden control panel accessible via passcode.
- Owner can deactivate/activate monitoring; auto-reactivation after a configurable period.

Use Cases
- Educational Labs: Demonstrate USB data theft scenarios and countermeasures.
- Red Team Simulation: Train defenders to detect and respond to USB exfiltration attempts.
- Forensics Training: Analyze logs to reconstruct attacker behavior.

Legal & Ethical Notice
- This platform is designed for:
   > Controlled environments only
   > With prior consent of all participants
   > For research, education, and authorized testing
   > Under no circumstances should any real-world unauthorized USB infection or tracking be attempted with this tool.

Tech Stack
- Language: Python (prototyping) + C#/C++ (system calls)
- Database: SQLite / PostgreSQL (with AES encryption)
- UI: Cross-platform desktop app (Tkinter, WPF, or Electron)
- Detection APIs: Win32 API (WM_DEVICECHANGE, ReadDirectoryChangesW), Linux udev + inotify
- Simulated Tracking: GeoIP + MAC/IP collection in lab mode

⚠️ LEGAL NOTICE: This project is governed by the Repository Ownership & Contribution Agreement.
By contributing to or accessing this repository, you agree to its terms.
See REPO_OWNERSHIP_AND_CONTRIBUTION_AGREEMENT.md for details.
