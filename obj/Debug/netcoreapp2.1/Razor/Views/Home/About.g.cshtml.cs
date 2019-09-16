#pragma checksum "C:\Users\t-xinma\source\repos\Keberos\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4f8518897f93187b5c1f844c195c2fcba2ccbf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\t-xinma\source\repos\Keberos\Views\_ViewImports.cshtml"
using Keberos;

#line default
#line hidden
#line 2 "C:\Users\t-xinma\source\repos\Keberos\Views\_ViewImports.cshtml"
using Keberos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f8518897f93187b5c1f844c195c2fcba2ccbf1", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b471277bf253a7c098d2556cac64f231a5236d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\t-xinma\source\repos\Keberos\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(41, 10687, true);
            WriteLiteral(@"
<style>
    .smq{
        font-size:14px;
        color:#606060;
    }
</style>
    <div style=""text-align:center"">
        <h2><strong>NTLM Protocol</strong></h2>
        <h3>New Technology LAN Manager</h3>
    </div>


<p>In a Windows network, NTLM is a suite of Microsoft security protocols intended to provide authentication, integrity, and confidentiality to users. NTLM is the successor to the authentication protocol in Microsoft LAN Manager (LANMAN), an older Microsoft product. The NTLM protocol suite is implemented in a Security Support Provider, which combines the LAN Manager authentication protocol, NTLMv1, NTLMv2 and NTLM2 Session protocols in a single package. Whether these protocols are used or can be used on a system is governed by Group Policy settings, for which different versions of Windows have different default settings. NTLM passwords are considered weak because they can be brute-forced very easily with modern hardware.</p>

<p>
    NTLM is a <strong>challenge-response authen");
            WriteLiteral(@"tication protocol</strong> which uses three messages to authenticate a client in a connection oriented environment (connectionless is similar), and a fourth additional message if integrity is desired.
    <ul>
        <li>
            First, the client establishes a network path to the server and sends a <i>NEGOTIATE_MESSAGE</i> advertising its capabilities.
        </li>
        <li>
            Next, the server responds with <i>CHALLENGE_MESSAGE</i> which is used to establish the identity of the client.
        </li>
        <li>
            Finally, the client responds to the challenge with an <i>AUTHENTICATE_MESSAGE</i>.
        </li>
    </ul>
      
    The NTLM protocol uses one or both of two hashed password values, both of which are also stored on the server (or domain controller), and which through a lack of salting are password equivalent, meaning that if you grab the hash value from the server, you can authenticate without knowing the actual password. The two are the <strong>LM Hash</");
            WriteLiteral(@"strong> (a DES-based function applied to the first 14 chars of the password converted to the traditional 8 bit PC charset for the language), and the <strong>NT Hash</strong> (MD4 of the little endian UTF-16 Unicode password). Both hash values are 16 bytes (128 bits) each.

    The NTLM protocol also uses one of two one-way functions, depending on the NTLM version. NT LanMan and NTLM version 1 use the DES based LanMan one way function (LMOWF), while NTLMv2 uses the NT MD4 based one way function (NTOWF).

</p>

<br />
<h4><strong>NTLMv1</strong></h4>
<p>  
    The server authenticates the client by sending an 8-byte random number, the challenge. The client performs an operation involving the challenge and a secret shared between client and server, specifically one of the two password hashes described above. The client returns the 24-byte result of the computation. In fact, in NTLMv1 the computations are usually made <strong>using both hashes</strong> and both 24-byte results are sent. The server verifi");
            WriteLiteral(@"es that the client has computed the correct result, and from this infers possession of the secret, and hence the authenticity of the client.
</p>
<p>
    Both the hashes produce 16-byte quantities. Five bytes of zeros are appended to obtain 21 bytes. The 21 bytes are separated in three 7-byte (56-bit) quantities. Each of these 56-bit quantities is used as a key to DES encrypt the 64 bit challenge. The three encryptions of the challenge are reunited to form the 24-byte response. Both the response using the LM hash and the NT hash are returned as the response, but this is configurable.
</p>
<blockquote class=""smq"">
    C = 8-byte server challenge, random
    <br />
    K1 | K2 | K3 = NTLM-Hash | 5-bytes-0
    <br />
    response = DES(K1,C) | DES(K2,C) | DES(K3,C)
</blockquote>

<h4><strong>NTLMv2</strong></h4>
<p>
    NTLM version 2 (NTLMv2), which was introduced in Windows NT 4.0 SP4 (and natively supported in Windows 2000), is intended as a cryptographically strengthened replacement for NTLMv1");
            WriteLiteral(@". It enhances NTLM security by hardening the protocol against many spoofing attacks, and adding the ability for a server to authenticate to the client.
</p>
<p>
    NTLMv2 sends two responses to an 8-byte server challenge. Each response contains a 16-byte HMAC-MD5 hash of the server challenge, a fully/partially randomly generated client challenge, and an HMAC-MD5 hash of the user's password and other identifying information. The two responses differ in the format of the client challenge.
</p>
<p>
    The shorter response uses an 8-byte random value for this challenge. In order to verify the response, the server must receive as part of the response the client challenge. For this shorter response, the 8-byte client challenge appended to the 16-byte response makes a 24-byte package which is consistent with the 24-byte response format of the previous NTLMv1 protocol. In certain non-official documentation (e.g. DCE/RPC Over SMB, Leighton) this response is termed <strong>LMv2</strong>.
</p>
<p>
    The sec");
            WriteLiteral(@"ond response sent by NTLMv2 uses a variable length client challenge which includes:
    <ol>
        <li>the current time in NT Time format</li>
        <li>an 8-byte random value (CC2 in the box below)</li>
        <li>the domain name</li>
        <li>some standard format stuff</li>
    </ol>
    The response must include a copy of this client challenge, and is therefore variable length. In non-official documentation, this response is termed <strong>NTv2</strong>.
</p>
<p>
    Both LMv2 and NTv2 hash the client and server challenge with the NT hash of the user's password and other identifying information. The exact formula is to begin with the NT Hash, which is stored in the SAM or AD, and continue to hash in, using HMAC-MD5, the username and domain name. In the box below, X stands for the fixed contents of a formatting field.
</p>
<blockquote class=""smq"">
    SC = 8-byte server challenge, random
    <br />
    CC = 8-byte client challenge, random
    <br />
    CC* = (X, time, CC2, domain n");
            WriteLiteral(@"ame)
    <br />
    v2-Hash = HMAC-MD5(NT-Hash, user name, domain name)
    <br />
    LMv2 = HMAC-MD5(v2-Hash, SC, CC)
    <br />
    NTv2 = HMAC-MD5(v2-Hash, SC, CC*)
    <br />
    response = LMv2 | CC | NTv2 | CC*
</blockquote>

<br />
<h3>Availability</h3>
<p>
    
    NTLM is widely deployed, even on new systems. The major reason is to maintain compatibility with older systems. However, it may not be used in many situations.

    Microsoft no longer recommends NTLM in applications:[18]

    <blockquote class=""smq"">
        ""Implementers should be aware that NTLM does not support any recent cryptographic methods, such as AES or SHA-256. It uses cyclic redundancy check (CRC) or message digest algorithms (RFC1321) for integrity, and it uses RC4 for encryption.

        Deriving a key from a password is as specified in RFC1320 and FIPS46-2. Therefore, applications are generally advised not to use NTLM.""
    </blockquote>
    

    <strong>Microsoft has added the NTLM hash to its im");
            WriteLiteral(@"plementation of the Kerberos protocol to improve interoperability (in particular, the RC4-HMAC encryption type).</strong> According to an independent researcher, this design decision allows Domain Controllers to be tricked into issuing an attacker with a Kerberos ticket if the NTLM hash is known.

    Microsoft adopted Kerberos as the preferred authentication protocol for Windows 2000 and subsequent Active Directory domains. <strong>Kerberos is typically used when a server belongs to a Windows Server domain.</strong> Microsoft recommends developers neither to use Kerberos nor the NTLM Security Support Provider (SSP) directly.

    <blockquote class=""smq"">
        Your application should not access the NTLM security package directly; instead, it should use the <strong>Negotiate security package</strong>. Negotiate allows your application to take advantage of more advanced security protocols if they are supported by the systems involved in the authentication. Currently, the Negotiate security package selec");
            WriteLiteral(@"ts between Kerberos and NTLM. Negotiate selects Kerberos unless it cannot be used by one of the systems involved in the authentication.

    </blockquote>
    
</p>

<h4>Use of NTLM Security Service Provider</h4>
<p>
    The NTLM SSP is used in the following situations:
    <ul>
        <li>
            The client is authenticating to a server that doesn't belong to a domain or no Active Directory domain exists (commonly referred to as ""workgroup"" or ""peer-to-peer"")
            <blockquote class=""smq"">
                The server must have the 'Password protected sharing' feature enabled, which is not enabled by default and which is mutually exclusive with HomeGroup on some versions of Windows.
                <br />
                When server and client both belong to the same HomeGroup, a protocol similar to Kerberos, Public Key Cryptography based User to User Authentication will be used instead of NTLM.[21] HomeGroup is probably the easiest way to share resources on a small network, requirin");
            WriteLiteral(@"g minimal setup, even compared to configuring a few additional users to be able to use Password protected sharing, which may mean it is used much more than Password protected sharing on small networks and home networks.
            </blockquote>
            
        </li>
        <li>
            If the server is a device that supports Server Message Block (SMB), such as NAS devices and network printers, the NTLM SSP may offer the only supported authentication method. Some implementations of SMB or older distributions of e.g. Samba may cause Windows to negotiate NTLMv1 or even LM for outbound authentication with the SMB server, allowing the device to work although it may be loaded with outdated, insecure software regardless of whether it were a new device.
        </li>
        <li>
            If the server is a member of a domain but Kerberos cannot be used.
            <blockquote class=""smq"">
                The client is authenticating to a server using an IP address (and no reverse name resolu");
            WriteLiteral(@"tion is available)
                <br />
                The client is authenticating to a server that belongs to a different Active Directory forest that has a legacy NTLM trust instead of a transitive inter-forest trust
                <br />
                Where a firewall would otherwise restrict the ports required by Kerberos (typically TCP 88)
            </blockquote>
            
        </li>
    </ul>
    
   
    
</p>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
