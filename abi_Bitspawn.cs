﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mint
{
    class abi_Bitspawn
    {
       string abi = @"[
    {
      'inputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'constructor'
    },
    {
      'anonymous': false,
      'inputs': [
        {
          'indexed': true,
          'internalType': 'address',
          'name': 'src',
          'type': 'address'
        },
        {
    'indexed': true,
          'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        },
        {
    'indexed': false,
          'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'Approval',
      'type': 'event'
    },
    {
    'anonymous': false,
      'inputs': [
        {
        'indexed': true,
          'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        },
        {
        'indexed': false,
          'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'Burn',
      'type': 'event'
    },
    {
    'anonymous': true,
      'inputs': [
        {
        'indexed': true,
          'internalType': 'bytes4',
          'name': 'sig',
          'type': 'bytes4'
        },
        {
        'indexed': true,
          'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        },
        {
        'indexed': true,
          'internalType': 'bytes32',
          'name': 'foo',
          'type': 'bytes32'
        },
        {
        'indexed': true,
          'internalType': 'bytes32',
          'name': 'bar',
          'type': 'bytes32'
        },
        {
        'indexed': false,
          'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        },
        {
        'indexed': false,
          'internalType': 'bytes',
          'name': 'fax',
          'type': 'bytes'
        }
      ],
      'name': 'LogNote',
      'type': 'event'
    },
    {
    'anonymous': false,
      'inputs': [
        {
        'indexed': true,
          'internalType': 'address',
          'name': 'authority',
          'type': 'address'
        }
      ],
      'name': 'LogSetAuthority',
      'type': 'event'
    },
    {
    'anonymous': false,
      'inputs': [
        {
        'indexed': true,
          'internalType': 'address',
          'name': 'owner',
          'type': 'address'
        }
      ],
      'name': 'LogSetOwner',
      'type': 'event'
    },
    {
    'anonymous': false,
      'inputs': [
        {
        'indexed': true,
          'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        },
        {
        'indexed': false,
          'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'Mint',
      'type': 'event'
    },
    {
    'anonymous': false,
      'inputs': [
        {
        'indexed': true,
          'internalType': 'address',
          'name': 'src',
          'type': 'address'
        },
        {
        'indexed': true,
          'internalType': 'address',
          'name': 'dst',
          'type': 'address'
        },
        {
        'indexed': false,
          'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'Transfer',
      'type': 'event'
    },
    {
    'anonymous': false,
      'inputs': [
        {
        'indexed': true,
          'internalType': 'address',
          'name': 'src',
          'type': 'address'
        },
        {
        'indexed': true,
          'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        },
        {
        'indexed': false,
          'internalType': 'bool',
          'name': 'wat',
          'type': 'bool'
        }
      ],
      'name': 'Trust',
      'type': 'event'
    },
    {
    'constant': true,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'src',
          'type': 'address'
        },
        {
        'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        }
      ],
      'name': 'allowance',
      'outputs': [
        {
        'internalType': 'uint256',
          'name': '',
          'type': 'uint256'
        }
      ],
      'payable': false,
      'stateMutability': 'view',
      'type': 'function'
    },
    {
    'constant': true,
      'inputs': [],
      'name': 'authority',
      'outputs': [
        {
        'internalType': 'contract DSAuthority',
          'name': '',
          'type': 'address'
        }
      ],
      'payable': false,
      'stateMutability': 'view',
      'type': 'function'
    },
    {
    'constant': true,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'src',
          'type': 'address'
        }
      ],
      'name': 'balanceOf',
      'outputs': [
        {
        'internalType': 'uint256',
          'name': '',
          'type': 'uint256'
        }
      ],
      'payable': false,
      'stateMutability': 'view',
      'type': 'function'
    },
    {
    'constant': true,
      'inputs': [],
      'name': 'decimals',
      'outputs': [
        {
        'internalType': 'uint256',
          'name': '',
          'type': 'uint256'
        }
      ],
      'payable': false,
      'stateMutability': 'view',
      'type': 'function'
    },
    {
    'constant': true,
      'inputs': [],
      'name': 'name',
      'outputs': [
        {
        'internalType': 'bytes32',
          'name': '',
          'type': 'bytes32'
        }
      ],
      'payable': false,
      'stateMutability': 'view',
      'type': 'function'
    },
    {
    'constant': true,
      'inputs': [],
      'name': 'owner',
      'outputs': [
        {
        'internalType': 'address',
          'name': '',
          'type': 'address'
        }
      ],
      'payable': false,
      'stateMutability': 'view',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'contract DSAuthority',
          'name': 'authority_',
          'type': 'address'
        }
      ],
      'name': 'setAuthority',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'owner_',
          'type': 'address'
        }
      ],
      'name': 'setOwner',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [],
      'name': 'start',
      'outputs': [],
      'payable': true,
      'stateMutability': 'payable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [],
      'name': 'stop',
      'outputs': [],
      'payable': true,
      'stateMutability': 'payable',
      'type': 'function'
    },
    {
    'constant': true,
      'inputs': [],
      'name': 'stopped',
      'outputs': [
        {
        'internalType': 'bool',
          'name': '',
          'type': 'bool'
        }
      ],
      'payable': false,
      'stateMutability': 'view',
      'type': 'function'
    },
    {
    'constant': true,
      'inputs': [],
      'name': 'symbol',
      'outputs': [
        {
        'internalType': 'bytes32',
          'name': '',
          'type': 'bytes32'
        }
      ],
      'payable': false,
      'stateMutability': 'view',
      'type': 'function'
    },
    {
    'constant': true,
      'inputs': [],
      'name': 'totalSupply',
      'outputs': [
        {
        'internalType': 'uint256',
          'name': '',
          'type': 'uint256'
        }
      ],
      'payable': false,
      'stateMutability': 'view',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'dst',
          'type': 'address'
        },
        {
        'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'transfer',
      'outputs': [
        {
        'internalType': 'bool',
          'name': '',
          'type': 'bool'
        }
      ],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'bytes32',
          'name': 'name_',
          'type': 'bytes32'
        }
      ],
      'name': 'setName',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': true,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'src',
          'type': 'address'
        },
        {
        'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        }
      ],
      'name': 'trusted',
      'outputs': [
        {
        'internalType': 'bool',
          'name': '',
          'type': 'bool'
        }
      ],
      'payable': false,
      'stateMutability': 'view',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        },
        {
        'internalType': 'bool',
          'name': 'wat',
          'type': 'bool'
        }
      ],
      'name': 'trust',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        },
        {
        'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'approve',
      'outputs': [
        {
        'internalType': 'bool',
          'name': '',
          'type': 'bool'
        }
      ],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'src',
          'type': 'address'
        },
        {
        'internalType': 'address',
          'name': 'dst',
          'type': 'address'
        },
        {
        'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'transferFrom',
      'outputs': [
        {
        'internalType': 'bool',
          'name': '',
          'type': 'bool'
        }
      ],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'dst',
          'type': 'address'
        },
        {
        'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'push',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'src',
          'type': 'address'
        },
        {
        'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'pull',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'src',
          'type': 'address'
        },
        {
        'internalType': 'address',
          'name': 'dst',
          'type': 'address'
        },
        {
        'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'move',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        },
        {
        'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'mint',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'mint',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'burn',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    },
    {
    'constant': false,
      'inputs': [
        {
        'internalType': 'address',
          'name': 'guy',
          'type': 'address'
        },
        {
        'internalType': 'uint256',
          'name': 'wad',
          'type': 'uint256'
        }
      ],
      'name': 'burn',
      'outputs': [],
      'payable': false,
      'stateMutability': 'nonpayable',
      'type': 'function'
    }
  ]";

        public string getABI()
        {
            return this.abi;
        }
    }
}
