# Kerberos-Intro-Web

A kerberos and NTLM protocol introduction website.

NTLM is weaker than the kerberos protocol. 

**Process**: 

Server and client try to communicate via HTTPs. However, one of them may not support it. They have to communicate using HTTP, a insecure protocol. Kerberos protocol therefore is needed. 

To use Kerberos, a lot of requirements need to be satisfied. When the requirements cannot be met for all, the LAS(Local Authentication service) of operating system would choose NTLM(New Technique LAN Manager) to authenticate. This is a protocol provided by Microsoft. 

**Catching packet**:

The packets can be caught by Net Monitor or Fiddler. The Fiddler can catch HTTPs while Net Monitor can't. The Netmonitor plays as the gateway and can catch packets of multiple layers.
